using System;
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

            // TODO: Merge?
            if (DecreaseDelay(ref deltaTime) && InDelay)
            {
                return;
            }

            ApplyProgressMod(ref deltaTime);
            ApplyProgress(deltaTime);
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
            if (Mathf.Approximately(value, default))
            {
                return;
            }

            LoopProgress += value;

            if (LoopProgress <= 0f)
            {
                if (CompletedLoops == 0)
                {
                    OnLoopRewound();
                }
                else
                {
                    var loopsCount = (int)Mathf.Abs(LoopProgress); // TODO
                    loopsCount += 1;
                    RewoundLoops______xxxxxxx(loopsCount);
                }
            }
            else if (LoopProgress >= 1f)
            {
                var loopsCount = (int)LoopProgress;
                CompleteLoops(loopsCount);
            }
            else
            {
                EvaluateStateBy_xxxxxxxxxxxxxxxx(LoopProgress);
            }
        }

        private void ApplyProgressMod(ref float value)
        {
            value /= Duration;
            value *= (float)_progressDirection;
        }

        protected abstract void EvaluateState(float time);

        protected void EvaluateStateBy_xxxxxxxxxxxxxxxx(float time, LoopMode loopMode, int loop) // TODO
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

        protected void EvaluateStateBy_xxxxxxxxxxxxxxxx(float time) // TODO
        {
            EvaluateStateBy_xxxxxxxxxxxxxxxx(time, LoopMode, CompletedLoops);
        }
    }
}