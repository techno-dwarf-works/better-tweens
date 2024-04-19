namespace Better.Tweens.Runtime.Triggers
{
    public class SleepTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Sleep();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsSleeping();
        }
    }
}