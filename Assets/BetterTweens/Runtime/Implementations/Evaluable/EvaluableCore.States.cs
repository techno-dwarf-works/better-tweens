namespace Better.Tweens.Runtime
{
    public abstract partial class EvaluableCore
    {
        protected internal override void OnStarted()
        {
            _rawProgress = 0f;
            _ease.SetSource(SettingsData.Ease);
            RemainingDelay = StartDelay;
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
            _rawProgress = LoopCount;
            RemainingDelay = 0f;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(1f);

            base.OnCompleted();
        }

        protected override void OnRewound()
        {
            _rawProgress = 0f;
            RemainingDelay = StartDelay;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(LoopProgress);

            base.OnRewound();
        }
    }
}