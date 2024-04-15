using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenStopped : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsStopped();

        public WaitTweenStopped(TweenCore source) : base(source)
        {
        }
    }
}