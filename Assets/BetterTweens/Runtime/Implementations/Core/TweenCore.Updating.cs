using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        internal void Tick(float deltaTime)
        {
            _handlingMachine.CurrentState?.Tick(deltaTime);
            OnUpdated();
        }

        protected virtual void OnUpdated()
        {
            ActionUtility.Invoke(Updated);
        }

        internal bool InvokeTriggers()
        {
            if (_triggers == null)
            {
                return false;
            }

            foreach (var trigger in _triggers)
            {
                if (trigger.TryInvoke(this))
                {
                    return true;
                }
            }

            return false;
        }

        internal bool DecreaseDelay(ref float value)
        {
            if (!InDelay) return false;

            var appliedValue = Mathf.Abs(value);
            appliedValue = Mathf.Min(appliedValue, RemainingDelay);

            RemainingDelay -= appliedValue;
            value -= appliedValue * Mathf.Sign(value);

            return true;
        }

        internal void ApplyProgress(float value)
        {
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
        }
        
        internal void DecreaseSleepTimer(float value)
        {
        }

        internal void ApplyTimeScale(ref float value)
        {
            value *= LocalTimeScale;
            if (DependGlobalTimeScale)
            {
                value *= SettingsData.GlobalTimeScale;
            }
        }

        internal void ApplyProgressMod(ref float value)
        {
            value /= Duration;
        }
    }
}