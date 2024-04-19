using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenCompletion : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsCompleted();

        public WaitForTweenCompletion(TweenCore source) : base(source)
        {
        }
    }
}