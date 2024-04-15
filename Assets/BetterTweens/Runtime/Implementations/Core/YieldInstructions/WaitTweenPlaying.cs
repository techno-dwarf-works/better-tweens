using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenPlaying : YieldInstruction<TweenCore>
    {
        public override bool keepWaiting => Source.IsPlaying();

        public WaitTweenPlaying(TweenCore source) : base(source)
        {
        }
    }
}