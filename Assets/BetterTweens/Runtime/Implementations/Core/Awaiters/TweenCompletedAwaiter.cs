using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenCompletedAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenCompletedAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsCompleted())
            {
                SetResult(true);
                return;
            }

            Source.Completed += OnSourceCompleted;
        }

        private void OnSourceCompleted()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Completed -= OnSourceCompleted;
        }
    }
}