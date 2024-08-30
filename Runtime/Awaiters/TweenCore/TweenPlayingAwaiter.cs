using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenPlayingAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenPlayingAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
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
            if (Source.IsPlaying())
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