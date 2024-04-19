using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenRewound : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsRewound();

        public WaitForTweenRewound(TweenCore source) : base(source)
        {
        }
    }
}