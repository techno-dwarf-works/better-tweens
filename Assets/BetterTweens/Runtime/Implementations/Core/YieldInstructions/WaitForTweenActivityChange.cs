using Better.Commons.Runtime.Helpers.YieldInstructions;

namespace Better.Tweens.Runtime
{
    public class WaitForTweenActivityChange : YieldInstruction<TweenCore>
    {
        private bool _changed;
        public override bool keepWaiting => !_changed;

        public WaitForTweenActivityChange(TweenCore source) : base(source)
        {
            WaitStateChange();
        }

        private void WaitStateChange()
        {
            _changed = false;
            Source.ActivityChanged += OnActivityChanged;
        }

        private void OnActivityChanged()
        {
            _changed = true;
            Source.ActivityChanged -= OnActivityChanged;
        }

        public override void Reset()
        {
            base.Reset();
            WaitStateChange();
        }
    }
}