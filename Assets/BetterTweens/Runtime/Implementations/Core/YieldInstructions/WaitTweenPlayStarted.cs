using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenPlayStarted : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsPlaying();

        public WaitTweenPlayStarted(TweenCore source) : base(source)
        {
        }
    }
}