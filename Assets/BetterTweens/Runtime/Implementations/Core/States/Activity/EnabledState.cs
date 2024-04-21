namespace Better.Tweens.Runtime.States
{
    public class EnabledState : ActivityState
    {
        public override void Enter()
        {
            base.Enter();
            
            TweenRegistry.Register(Source);
            Source.OnEnabled();
        }

        public override void Exit()
        {
            base.Exit();
            
            TweenRegistry.Unregister(Source);
        }
    }
}