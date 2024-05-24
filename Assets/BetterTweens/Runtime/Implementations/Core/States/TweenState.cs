using Better.StateMachine.Runtime.States;

namespace Better.Tweens.Runtime.States
{
    public abstract class TweenState : SynchronousState
    {
        protected TweenCore Source { get; private set; }
        protected bool IsActive { get; private set; }

        public virtual void Setup(TweenCore source)
        {
            Source = source;
        }

        public override void Enter()
        {
            IsActive = true;
        }

        public override void OnEntered()
        {
        }

        public override void Exit()
        {
            IsActive = false;
        }

        public override void OnExited()
        {
        }
    }
}