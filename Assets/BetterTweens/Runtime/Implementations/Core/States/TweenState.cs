using Better.StateMachine.Runtime.States;

namespace Better.Tweens.Runtime.States
{
    public abstract class TweenState : SynchronousState
    {
        protected TweenCore Source { get; private set; }

        public virtual void Setup(TweenCore source)
        {
            Source = source;
        }

        public override void Enter()
        {
        }

        public virtual void Tick(float deltaTime)
        {
        }

        public override void Exit()
        {
        }
    }
}