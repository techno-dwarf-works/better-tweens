using System.Threading;
using Better.Tweens.Runtime.Actions;

namespace Better.Tweens.Runtime.Triggers
{
    public class CancellationTokenTrigger : ActionTrigger
    {
        private readonly CancellationToken _cancellationToken;

        public CancellationTokenTrigger(string id, TweenCoreAction action, CancellationToken cancellationToken)
            : base(id, action)
        {
            _cancellationToken = cancellationToken;
        }

        public override bool Invoke(TweenCore tweenCore)
        {
            return _cancellationToken.IsCancellationRequested && base.Invoke(tweenCore);
        }
    }
}