namespace Better.Tweens.Runtime.Triggers
{
    public class RestartTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Restart();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return true;
        }
    }
}