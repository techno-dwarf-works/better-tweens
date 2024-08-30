using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public abstract class TweenLoopAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        protected const int MinCount = 1;
        protected int CachedCompletedLoops { get; private set; }

        public TweenLoopAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            CachedCompletedLoops = Source.CompletedLoops;
        }
    }
}