namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        public override bool InstantCompleteLoop()
        {
            LoopProgress = 0f;

            return base.InstantCompleteLoop();
        }

        protected override void OnLoopCompleted()
        {
            RemainingDelay = LoopDelay;
            EvaluateStateByLoop(1f);

            base.OnLoopCompleted();
        }

        public override bool InstantRewoundLoop()
        {
            LoopProgress = CompletedLoops > 0 ? 1f : 0f;

            return base.InstantRewoundLoop();
        }

        protected override void OnLoopRewound()
        {
            RemainingDelay = CompletedLoops == 0 ? StartDelay : LoopDelay;
            EvaluateStateByLoop(0f);

            base.OnLoopRewound();
        }
    }
}