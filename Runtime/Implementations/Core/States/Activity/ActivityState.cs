namespace Better.Tweens.Runtime.States
{
    public abstract class ActivityState : TweenState
    {
        public override void OnEntered()
        {
            base.OnEntered();

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