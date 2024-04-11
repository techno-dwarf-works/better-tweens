using System;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected abstract void EvaluateState(float time);

        private void EvaluateStateByMode(float time)
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