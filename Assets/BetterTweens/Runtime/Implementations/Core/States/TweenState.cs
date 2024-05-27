using System.Threading;
using Better.StateMachine.Runtime.States;

namespace Better.Tweens.Runtime.States
{
    public abstract class TweenState : SynchronousState
    {
        private CancellationTokenSource _tokenSource;

        public CancellationToken Token => _tokenSource.Token;
        protected TweenCore Source { get; private set; }

        public virtual void Setup(TweenCore source)
        {
            Source = source;
            
            _tokenSource = new();
            _tokenSource.Cancel();
        }

        public override void Enter()
        {
        }

        public override void OnEntered()
        {
            _tokenSource = new();
        }

        public override void Exit()
        {
        }

        public override void OnExited()
        {
            _tokenSource.Cancel();
        }
    }
}