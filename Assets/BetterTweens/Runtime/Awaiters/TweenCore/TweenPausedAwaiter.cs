using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenPausedAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenPausedAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsPaused())
            {
                SetResult(true);
                return;
            }

            Source.Paused += OnPaused;
        }

        private void OnPaused()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Paused -= OnPaused;
        }
    }
}