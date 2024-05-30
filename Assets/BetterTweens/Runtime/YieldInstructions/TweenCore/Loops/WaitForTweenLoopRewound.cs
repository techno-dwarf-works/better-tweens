using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenLoopRewound : WaitForTweenLoop
    {
        private readonly int _count;
        public override bool keepWaiting => !Source.IsRewound() && CachedCompletedLoops - _count < Source.CompletedLoops;

        public WaitForTweenLoopRewound(TweenCore source, int count = MinCount) : base(source)
        {
            _count = Mathf.Max(MinCount, count);
        }
    }
}