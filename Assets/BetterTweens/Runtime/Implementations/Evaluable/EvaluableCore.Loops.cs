namespace Better.Tweens.Runtime
{
    public abstract partial class EvaluableCore
    {
        protected override void OnLoopCompleted()
        {
            // TODO: fix inversed when PingPong
            EvaluateStateByMode(1f);
            RemainingDelay = LoopDelay;
            TryHandleOverLoops();
            
            base.OnLoopCompleted();
        }

        protected override void OnLoopRewound()
        {
            // TODO: fix inversed when PingPong
            EvaluateStateByMode(0f);
            var delay = CompletedLoops == 1 ? StartDelay : LoopDelay;
            RemainingDelay = delay;
            
            base.OnLoopRewound();
        }

        private void TryHandleOverLoops()
        {
            if (CompletedLoops > ThresholdOverLoops)
            {
                _rawProgress %= ThresholdOverLoops;
            }
        }
    }
}