using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenRewound : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsRewound();

        public WaitTweenRewound(TweenCore source) : base(source)
        {
        }
    }
}