using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenCompleted : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsCompleted();

        public WaitTweenCompleted(TweenCore source) : base(source)
        {
        }
    }
}