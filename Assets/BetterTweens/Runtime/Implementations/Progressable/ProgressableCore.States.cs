namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected internal override void OnStarted()
        {
            _ease.SetSource(SettingsData.Ease);
            RemainingDelay = StartDelay;
            LoopProgress = 0f;
            EvaluateStateByLoop(LoopProgress);

            base.OnStarted();

            if (IsRunning() && InfinityLoops && Duration <= MinTime)
            {
                // TODO: Log?
                Stop();
            }
        }

        protected internal override void OnPlay()
        {
            _progressDirection = ProgressDirection.Forward;

            base.OnPlay();

            if (IsPlaying() && Duration <= MinTime)
            {
                InstantComplete();
            }
        }

        protected internal override void OnRewind()
        {
            _progressDirection = ProgressDirection.Backward;

            base.OnRewind();

            if (IsRewinding() && Duration <= MinTime)
            {
                InstantRewound();
            }
        }

        protected override void OnCompleted()
        {
            RemainingDelay = 0f;
            LoopProgress = 1f;
            EvaluateStateByLoop(LoopProgress);

            base.OnCompleted();
        }

        protected override void OnRewound()
        {
            RemainingDelay = StartDelay;
            LoopProgress = 0f;
            EvaluateStateByLoop(LoopProgress);

            base.OnRewound();
        }
    }
}