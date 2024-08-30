using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenStateChangeAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenStateChangeAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            Source.StateChanged += OnStateChanged;
        }

        private void OnStateChanged()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.StateChanged -= OnStateChanged;
        }
    }
}