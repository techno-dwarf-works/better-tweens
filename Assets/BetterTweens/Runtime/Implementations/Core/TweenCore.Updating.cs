using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        internal void ApplyProgress(float value)
        {
            if (DecreaseDelay(ref value) && InDelay)
            {
                return;
            }

            var rootCompletedLoops = CompletedLoops;
            var stateMod = _stateMachine.CurrentState.ProgressMod;
            var progressMod = Time.timeScale * stateMod / DerivedProperties.Duration; // TODO progress mod (time scale, etc)

            _rawProgress += value * progressMod;
            _rawProgress = Mathf.Clamp(_rawProgress, default, DerivedProperties.LoopCount);

            var completedLoopChanged = CompletedLoops != rootCompletedLoops;
            var rewoundCompleted = Mathf.Approximately(_rawProgress, default) && !Mathf.Approximately(value, default);
            if (completedLoopChanged || rewoundCompleted)
            {
                if (CompletedLoops > rootCompletedLoops)
                {
                    var completedCount = CompletedLoops - rootCompletedLoops;
                    OnLoopsCompleted(completedCount);
                }
                else
                {
                    var rewoundCount = Mathf.Max(rootCompletedLoops - CompletedLoops, 1);
                    OnLoopsRewound(rewoundCount);
                }
            }
            else
            {
                EvaluateStateByMode();
            }

            OnUpdated();
        }

        private bool DecreaseDelay(ref float value)
        {
            if (!InDelay) return false;

            value = Mathf.Min(value, RemainingDelay);
            RemainingDelay -= value;
            return true;
        }

        private void OnUpdated()
        {
            CallbackUtility.InvokeWithSafety(Updated);
        }
    }
}