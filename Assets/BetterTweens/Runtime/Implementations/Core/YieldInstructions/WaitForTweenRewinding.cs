using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenRewinding : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => Source.IsRewinding();

        public WaitForTweenRewinding(TweenCore source) : base(source)
        {
        }
    }
}