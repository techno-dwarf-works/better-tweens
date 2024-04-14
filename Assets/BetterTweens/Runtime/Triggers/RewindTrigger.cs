namespace Better.Tweens.Runtime.Triggers
{
    public class RewindTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Rewind();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsStopped() && !tweenCore.IsRewinding();
        }
    }
}