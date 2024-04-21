using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        internal void OnUpdate(float deltaTime)
        {
            if (InvokeTriggers())
            {
                return;
            }

            ApplyTimeScale(ref deltaTime);
            _activityMachine.CurrentState?.OnUpdate(deltaTime);

            if (IsEnabled() && !DecreaseDelay(ref deltaTime) || !InDelay)
            {
                ApplyProgressMod(ref deltaTime);
                ApplyProgress(deltaTime);
            }

            OnUpdated();
        }

        protected virtual void OnUpdated()
        {
            ActionUtility.Invoke(Updated);
        }

        private bool InvokeTriggers()
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

        private bool DecreaseDelay(ref float value)
        {
            if (!InDelay) return false;

            var appliedValue = Mathf.Abs(value);
            appliedValue = Mathf.Min(appliedValue, RemainingDelay);

            RemainingDelay -= appliedValue;
            value -= appliedValue * Mathf.Sign(value);

            return true;
        }

        private void ApplyProgress(float value)
        {
            var rootCompletedLoops = CompletedLoops;
            _rawProgress += value;
            _rawProgress = Math.Clamp(_rawProgress, default, LoopCount);

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
                var time = Ease.Evaluate(LoopProgress);
                EvaluateStateByMode(time);
            }
        }

        private void ApplyTimeScale(ref float value)
        {
            value *= LocalTimeScale;
            if (DependGlobalTimeScale)
            {
                value *= SettingsData.GlobalTimeScale;
            }
        }

        private void ApplyProgressMod(ref float value)
        {
            value /= Duration;
        }

        private void TryHandleOverLoops()
        {
            if (CompletedLoops < ThresholdOverLoops)
            {
                return;
            }

            // TODO: 1_000_000+1 loop error???
            // TODO: fix???
            // TODO: arki dupa
            _rawProgress -= ThresholdOverLoops;
            if (!InfinityLoops)
            {
                var loopCount = LoopCount - ThresholdOverLoops;
                if (loopCount == 0)
                {
                    _rawProgress++;
                }

                _loopCount.SetValue(loopCount);
            }
        }
    }
}