using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenRewinding : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => Source.IsRewinding();

        public WaitTweenRewinding(TweenCore source) : base(source)
        {
        }
    }
}