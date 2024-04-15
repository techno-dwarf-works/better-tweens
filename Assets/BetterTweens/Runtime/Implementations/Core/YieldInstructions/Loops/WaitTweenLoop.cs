using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public abstract class WaitTweenLoop : YieldInstruction<TweenCore>
    {
        public const int MinCount = 1;
        protected int CachedCompletedLoops { get; private set; }

        protected WaitTweenLoop(TweenCore source) : base(source)
        {
            CacheCompletedLoops();
        }

        private void CacheCompletedLoops()
        {
            CachedCompletedLoops = Source.CompletedLoops;
        }

        public override void Reset()
        {
            base.Reset();
            CacheCompletedLoops();
        }
    }
}