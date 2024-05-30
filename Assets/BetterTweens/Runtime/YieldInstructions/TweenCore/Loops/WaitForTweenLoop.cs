using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public abstract class WaitForTweenLoop : YieldInstruction<TweenCore>
    {
        public const int MinCount = 1;
        protected int CachedCompletedLoops { get; private set; }

        protected WaitForTweenLoop(TweenCore source) : base(source)
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