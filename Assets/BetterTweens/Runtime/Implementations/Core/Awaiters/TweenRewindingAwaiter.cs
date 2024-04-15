using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenRewindingAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenRewindingAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (TryComplete())
            {
                return;
            }

            Source.StateChanged += OnStateChanged;
        }

        private void OnStateChanged()
        {
            TryComplete();
        }

        private bool TryComplete()
        {
            if (Source.IsRewinding())
            {
                return false;
            }

            SetResult(true);
            return true;
        }

        protected override void OnCompleted(bool result)
        {
            Source.StateChanged -= OnStateChanged;
        }
    }
}