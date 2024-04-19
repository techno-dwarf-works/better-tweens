using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenUpdated : YieldInstruction<TweenCore>
    {
        private bool _updated;
        public override bool keepWaiting => !_updated;

        public WaitForTweenUpdated(TweenCore source) : base(source)
        {
            WaitUpdating();
        }

        private void WaitUpdating()
        {
            _updated = false;
            Source.Updated += OnUpdated;
        }

        private void OnUpdated()
        {
            _updated = true;
            Source.Updated -= OnUpdated;
        }

        public override void Reset()
        {
            base.Reset();
            WaitUpdating();
        }
    }
}