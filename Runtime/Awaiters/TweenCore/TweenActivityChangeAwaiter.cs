using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenActivityChangeAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenActivityChangeAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            Source.ActivityChanged += OnActivityChanged;
        }

        private void OnActivityChanged()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.ActivityChanged -= OnActivityChanged;
        }
    }
}