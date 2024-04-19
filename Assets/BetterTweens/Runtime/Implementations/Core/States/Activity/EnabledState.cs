namespace Better.Tweens.Runtime.States
{
    public class EnabledState : ActivityState
    {
        public override void Enter()
        {
            base.Enter();
            Source.OnEnabled();
        }
    }
}