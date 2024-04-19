namespace Better.Tweens.Runtime.Triggers
{
    public class PauseTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Pause();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return tweenCore.IsRunning();
        }
    }
}