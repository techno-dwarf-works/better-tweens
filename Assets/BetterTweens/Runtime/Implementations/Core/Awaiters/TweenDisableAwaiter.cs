using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenDisableAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenDisableAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsDisabled())
            {
                SetResult(true);
                return;
            }

            Source.Disabled += OnDisabled;
        }

        private void OnDisabled()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Disabled -= OnDisabled;
        }
    }
}