namespace Better.Tweens.Runtime.Triggers
{
    public class DisableTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Disable();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsDisabled();
        }
    }
}