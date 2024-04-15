using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenActivatedAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenActivatedAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsCompleted())
            {
                SetResult(true);
                return;
            }

            Source.Activated += OnActivated;
        }

        private void OnActivated()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Activated -= OnActivated;
        }
    }
}