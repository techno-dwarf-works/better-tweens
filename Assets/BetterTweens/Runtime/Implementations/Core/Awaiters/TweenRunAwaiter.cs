using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenRunAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenRunAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsRunning())
            {
                SetResult(true);
                return;
            }

            Source.Runned += OnRunned;
        }

        private void OnRunned()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Runned -= OnRunned;
        }
    }
}