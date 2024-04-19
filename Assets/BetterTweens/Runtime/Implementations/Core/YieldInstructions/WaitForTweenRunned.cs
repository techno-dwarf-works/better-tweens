using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenRunned : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsRunning();

        public WaitForTweenRunned(TweenCore source) : base(source)
        {
        }
    }
}