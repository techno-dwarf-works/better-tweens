namespace Better.Tweens.Runtime.States
{
    public abstract class ActivityState : TweenState
    {
        public override void Enter()
        {
            base.Enter();
            
            Reset();
        }

        public virtual void OnUpdate(float deltaTime)
        {
        }

        public virtual void Reset()
        {
        }
    }
}