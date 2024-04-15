using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class WaitTweenLoopRewound : WaitTweenLoop
    {
        private readonly int _count;
        public override bool keepWaiting => !Source.IsRewound() && CachedCompletedLoops - _count < Source.CompletedLoops;

        public WaitTweenLoopRewound(TweenCore source, int count = MinCount) : base(source)
        {
            _count = Mathf.Max(MinCount, count);
        }
    }
}