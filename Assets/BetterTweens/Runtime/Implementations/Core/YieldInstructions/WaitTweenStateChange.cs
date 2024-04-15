using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitTweenStateChange : YieldInstruction<TweenCore>
    {
        private bool _changed;
        public override bool keepWaiting => !_changed;

        public WaitTweenStateChange(TweenCore source) : base(source)
        {
            WaitStateChange();
        }

        private void WaitStateChange()
        {
            _changed = false;
            Source.StateChanged += OnStateChanged;
        }

        private void OnStateChanged()
        {
            _changed = true;
            Source.StateChanged -= OnStateChanged;
        }

        public override void Reset()
        {
            base.Reset();
            WaitStateChange();
        }
    }
}