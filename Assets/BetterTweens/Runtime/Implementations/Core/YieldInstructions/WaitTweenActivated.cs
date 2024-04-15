using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenActivated : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsActive();

        public WaitTweenActivated(TweenCore source) : base(source)
        {
        }
    }
}