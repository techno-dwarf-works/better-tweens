using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenStopped : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsStopped();

        public WaitForTweenStopped(TweenCore source) : base(source)
        {
        }
    }
}