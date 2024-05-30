using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenLoopCompleted : WaitForTweenLoop
    {
        private readonly int _count;
        public override bool keepWaiting => !Source.IsCompleted() && CachedCompletedLoops + _count > Source.CompletedLoops;

        public WaitForTweenLoopCompleted(TweenCore source, int count = MinCount) : base(source)
        {
            _count = Mathf.Max(MinCount, count);
        }
    }
}