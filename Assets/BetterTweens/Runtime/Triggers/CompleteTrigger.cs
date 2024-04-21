namespace Better.Tweens.Runtime.Triggers
{
    public class CompleteTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Complete();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsCompleted();
        }
    }
}