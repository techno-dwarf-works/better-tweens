using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenAsleep : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsSleeping();

        public WaitForTweenAsleep(TweenCore source) : base(source)
        {
        }
    }
}