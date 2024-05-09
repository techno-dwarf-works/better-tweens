namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected internal override void OnStarted()
        {
            _ease.SetSource(SettingsData.Ease);
            RemainingDelay = StartDelay;
            LoopProgress = 0f;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(LoopProgress);

            base.OnStarted();
        }

        protected internal override void OnPlay()
        {
            _progressDirection = ProgressDirection.Forward;

            base.OnPlay();
        }

        protected internal override void OnRewind()
        {
            _progressDirection = ProgressDirection.Backward;

            base.OnRewind();
        }

        protected override void OnCompleted()
        {
            RemainingDelay = 0f;
            LoopProgress = 1f;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(LoopProgress);

            base.OnCompleted();
        }

        protected override void OnRewound()
        {
            RemainingDelay = StartDelay;
            LoopProgress = 0f;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(LoopProgress);

            base.OnRewound();
        }
    }
}