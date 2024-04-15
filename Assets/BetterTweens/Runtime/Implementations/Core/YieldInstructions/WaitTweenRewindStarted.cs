using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenRewindStarted : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsRewinding();

        public WaitTweenRewindStarted(TweenCore source) : base(source)
        {
        }
    }
}