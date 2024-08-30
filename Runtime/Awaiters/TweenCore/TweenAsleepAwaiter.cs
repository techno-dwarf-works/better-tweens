using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenAsleepAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenAsleepAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsSleeping())
            {
                SetResult(true);
                return;
            }

            Source.Asleep += OnAsleep;
        }

        private void OnAsleep()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Asleep -= OnAsleep;
        }
    }
}