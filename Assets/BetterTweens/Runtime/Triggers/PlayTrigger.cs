namespace Better.Tweens.Runtime.Triggers
{
    public class PlayTrigger : Trigger
    {
        protected override void Invoke(TweenCore tweenCore)
        {
            tweenCore.Play();
        }

        protected override bool IsValidFor(TweenCore tweenCore)
        {
            return !tweenCore.IsPlaying();
        }
    }
}