namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected override void CompleteLoop()
        {
            LoopProgress = 0f;

            base.CompleteLoop();
        }

        protected override void RewoundLoop()
        {
            LoopProgress = CompletedLoops > 0 ? 1f : 0f;

            base.RewoundLoop();
        }

        protected override void OnLoopCompleted()
        {
            EvaluateStateByLoop(1f);
            RemainingDelay = LoopDelay;

            base.OnLoopCompleted();
        }

        protected override void OnLoopRewound()
        {
            EvaluateStateByLoop(0f);
            RemainingDelay = CompletedLoops == 0 ? StartDelay : LoopDelay;

            base.OnLoopRewound();
        }
    }
}