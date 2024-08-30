using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenRewindStartedAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenRewindStartedAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsRewinding())
            {
                SetResult(true);
                return;
            }

            Source.Rewinding += OnRewinding;
        }

        private void OnRewinding()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Rewinding -= OnRewinding;
        }
    }
}