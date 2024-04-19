using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenPlaying : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => Source.IsPlaying();

        public WaitForTweenPlaying(TweenCore source) : base(source)
        {
        }
    }
}