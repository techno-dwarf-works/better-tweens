using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenUpdateAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenUpdateAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            Source.Updated += OnUpdated;
        }

        private void OnUpdated()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Updated -= OnUpdated;
        }
    }
}