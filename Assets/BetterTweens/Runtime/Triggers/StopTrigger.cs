namespace Better.Tweens.Runtime.Triggers
{
    public class StopTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Stop();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsStopped();
        }
    }
}