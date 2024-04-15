using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenPaused : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsPaused();

        public WaitTweenPaused(TweenCore source) : base(source)
        {
        }
    }
}