using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected override void OnPreUpdated(float deltaTime)
        {
            base.OnPreUpdated(deltaTime);

            if (!IsEnabled())
            {
                return;
            }

            if (InDelay)
            {
                DecreaseDelay(ref deltaTime);
                if (InDelay)
                {
                    return;
                }
            }

            ApplyProgressMod(ref deltaTime);
            ApplyProgress(deltaTime);
        }

        private void DecreaseDelay(ref float value)
        {
            if (!InDelay)
            {
                var message = "Unexpected operation, not delayed";
                LogUtility.LogException(message);
                return;
            }

            var appliedValue = Mathf.Min(value, RemainingDelay);
            RemainingDelay -= appliedValue;
            value -= appliedValue;
        }

        private void ApplyProgress(float value)
        {
            if (Mathf.Approximately(value, default))
            {
                return;
            }

            LoopProgress += value;
            if (LoopProgress > 0f && LoopProgress < 1f)
            {
                EvaluateStateByLoop(LoopProgress);
                return;
            }

            var rootStateToken = GetHandlingStateToken();
            var extraProgress = 0f;
            
            if (LoopProgress > 0f)
            {
                var loopsCount = (int)LoopProgress;
                extraProgress += LoopProgress - loopsCount;
                InstantCompleteLoops(loopsCount);
            }
            else
            {
                var absedLoopProgress = Mathf.Abs(LoopProgress);
                var loopsCount = (int)absedLoopProgress + 1;
                extraProgress -= absedLoopProgress % 1f;
                InstantRewoundLoops(loopsCount);
            }
            
            if (!rootStateToken.IsCancellationRequested)
            {
                LoopProgress += extraProgress;
            }
        }

        private void ApplyProgressMod(ref float value)
        {
            value /= Duration;
            value *= _progressDirectionMod;
        }

        protected abstract void EvaluateState(float time);

        protected void EvaluateStateByLoop(float time, LoopMode loopMode, int loop)
        {
            time = Ease.Evaluate(time);
            time = loopMode switch
            {
                LoopMode.Restart or LoopMode.Incremental => time,
                LoopMode.PingPong => loop % 2 == 0 ? 1f - time : time,
                _ => throw new ArgumentOutOfRangeException(nameof(loopMode))
            };

            EvaluateState(time);
        }

        protected void EvaluateStateByLoop(float time)
        {
            EvaluateStateByLoop(time, LoopMode, CompletedLoops);
        }
    }
}