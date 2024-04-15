using Better.Tweens.Runtime.Triggers;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        internal void ApplyProgress(float value)
        {
            ApplyProgressMod(ref value);

            if (DecreaseDelay(ref value) && InDelay)
            {
                return;
            }

            var rootCompletedLoops = CompletedLoops;
            _rawProgress += value;
            _rawProgress = Mathf.Clamp(_rawProgress, default, LoopCount);

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
                var time = _ease.Value.Evaluate(LoopProgress);
                EvaluateStateByMode(time);
            }

            OnUpdated();
        }

        internal bool TickTriggers()
        {
            if (_triggers == null)
            {
                return true;
            }

            foreach (var trigger in _triggers)
            {
                if (trigger.TryInvoke(this))
                {
                    return false;
                }
            }

            return true;
        }

        private void ApplyProgressMod(ref float value)
        {
            value *= _stateMachine.CurrentState.DirectionMod;
            value *= LocalTimeScale;
            value /= Duration;

            if (DependGlobalTimeScale)
            {
                value *= SettingsData.GlobalTimeScale;
            }
        }

        private bool DecreaseDelay(ref float value)
        {
            if (!InDelay) return false;

            var appliedValue = Mathf.Abs(value);
            appliedValue = Mathf.Min(appliedValue, RemainingDelay);

            RemainingDelay -= appliedValue;
            value -= appliedValue * Mathf.Sign(value);

            return true;
        }

        private void OnUpdated()
        {
            ActionUtility.Invoke(Updated);
        }
    }
}