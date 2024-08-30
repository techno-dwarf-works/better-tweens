namespace Better.Tweens.Runtime.States
{
    public class EnabledState : ActivityState
    {
        public override void OnEntered()
        {
            base.OnEntered();

            TweenRegistry.Register(Source);
            Source.OnEnabled();
        }

        public override void OnExited()
        {
            base.OnExited();

            TweenRegistry.Unregister(Source);
        }
    }
}