using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenPaused : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsPaused();

        public WaitForTweenPaused(TweenCore source) : base(source)
        {
        }
    }
}