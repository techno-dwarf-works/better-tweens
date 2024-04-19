using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenRewindStarted : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsRewinding();

        public WaitForTweenRewindStarted(TweenCore source) : base(source)
        {
        }
    }
}