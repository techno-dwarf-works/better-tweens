using System.Threading;
using Better.Commons.Runtime.Helpers.CompletionAwaiters;

namespace Better.Tweens.Runtime
{
    public class TweenRewoundAwaiter : CompletionAwaiter<TweenCore, bool>
    {
        public TweenRewoundAwaiter(TweenCore source, CancellationToken cancellationToken) : base(source, cancellationToken)
        {
            if (Source.IsRewound())
            {
                SetResult(true);
                return;
            }

            Source.Rewound += OnRewound;
        }

        private void OnRewound()
        {
            SetResult(true);
        }

        protected override void OnCompleted(bool result)
        {
            Source.Rewound -= OnRewound;
        }
    }
}