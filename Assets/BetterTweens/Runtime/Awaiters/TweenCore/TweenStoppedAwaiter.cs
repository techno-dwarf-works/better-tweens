using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenStoppedAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenStoppedAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsStopped())
            {
                SetResult(true);
                return;
            }

            Source.Stopped += OnStopped;
        }

        private void OnStopped()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Stopped -= OnStopped;
        }
    }
}