namespace Better.Tweens.Runtime.Triggers
{
    public class EnableTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Enable();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsEnabled();
        }
    }
}