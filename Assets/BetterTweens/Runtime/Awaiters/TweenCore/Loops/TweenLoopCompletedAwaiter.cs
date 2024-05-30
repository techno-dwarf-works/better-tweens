using System.Threading;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class TweenLoopCompletedAwaiter : TweenLoopAwaiter
    {
        private readonly int _count;

        public TweenLoopCompletedAwaiter(TweenCore source, CancellationToken cancellationToken, int count = MinCount)
            : base(source, cancellationToken)
        {
            _count = Mathf.Max(MinCount, count);
            Source.LoopCompleted += OnCallback;
        }

        private void OnCallback()
        {
            if (Source.IsCompleted() || CachedCompletedLoops + _count <= Source.CompletedLoops)
            {
                SetResult(true);
            }
        }

        protected override void OnCompleted(bool result)
        {
            Source.LoopCompleted -= OnCallback;
        }
    }
}