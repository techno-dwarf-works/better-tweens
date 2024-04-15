using System.Threading;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class TweenLoopRewoundAwaiter : TweenLoopAwaiter
    {
        private readonly int _count;

        public TweenLoopRewoundAwaiter(TweenCore source, CancellationToken cancellationToken, int count = MinCount)
            : base(source, cancellationToken)
        {
            _count = Mathf.Max(MinCount, count);
            Source.LoopRewound += OnCallback;
        }

        private void OnCallback()
        {
            if (Source.IsCompleted() || CachedCompletedLoops - _count >= Source.CompletedLoops)
            {
                SetResult(true);
            }
        }

        protected override void OnCompleted(bool result)
        {
            Source.LoopRewound -= OnCallback;
        }
    }
}