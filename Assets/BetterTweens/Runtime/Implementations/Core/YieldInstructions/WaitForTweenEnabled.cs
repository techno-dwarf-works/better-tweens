using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenEnabled : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => !Source.IsEnabled();

        public WaitForTweenEnabled(TweenCore source) : base(source)
        {
        }
    }
}