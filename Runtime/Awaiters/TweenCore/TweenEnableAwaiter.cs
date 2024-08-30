using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenEnableAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenEnableAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsEnabled())
            {
                SetResult(true);
                return;
            }

            Source.Enabled += OnEnabled;
        }

        private void OnEnabled()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Enabled -= OnEnabled;
        }
    }
}