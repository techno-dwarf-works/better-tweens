using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenDisabled : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsDisabled();

        public WaitForTweenDisabled(TweenCore source) : base(source)
        {
        }
    }
}