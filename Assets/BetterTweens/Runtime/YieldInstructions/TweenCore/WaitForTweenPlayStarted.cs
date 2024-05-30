using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenPlayStarted : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsPlaying();

        public WaitForTweenPlayStarted(TweenCore source) : base(source)
        {
        }
    }
}