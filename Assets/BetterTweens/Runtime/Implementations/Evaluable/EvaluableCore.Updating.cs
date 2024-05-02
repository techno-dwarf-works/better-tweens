using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class EvaluableCore
    {
        protected override void OnPreUpdated(float deltaTime)
        {
            base.OnPreUpdated(deltaTime);

            // TODO: check tick when Sleeping
            if (IsEnabled() && !DecreaseDelay(ref deltaTime) || !InDelay)
            {
                ApplyProgressMod(ref deltaTime);
                ApplyProgress(deltaTime);
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
        
        private void ApplyProgressMod(ref float value)
        {
            value /= Duration;
        }
        
        protected abstract void EvaluateState(float time);

        protected void EvaluateStateByMode(float time)
        {
            var evaluatedTime = LoopMode switch
            {
                LoopMode.Restart or LoopMode.Incremental => time,
                LoopMode.PingPong => CompletedLoops % 2 == 0 ? 1f - time : time,
                _ => throw new ArgumentOutOfRangeException(nameof(LoopMode))
            };

            EvaluateState(evaluatedTime);
        }
    }
}