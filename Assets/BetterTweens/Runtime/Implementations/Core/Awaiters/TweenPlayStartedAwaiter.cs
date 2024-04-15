using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenPlayStartedAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenPlayStartedAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsPlaying())
            {
                SetResult(true);
                return;
            }

            Source.Playing += OnPlaying;
        }

        private void OnPlaying()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Playing -= OnPlaying;
        }
    }
}