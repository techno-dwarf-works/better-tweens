namespace Better.Tweens.Runtime.Triggers
{
    public class TogglePauseTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.TogglePause();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsStopped();
        }
    }
}