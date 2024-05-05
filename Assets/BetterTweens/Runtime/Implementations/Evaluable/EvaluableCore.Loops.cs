using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class EvaluableCore
    {
        protected override void CompleteLoop()
        {
            _rawProgress = CompletedLoops + 1;
            base.CompleteLoop();
        }

        protected override void OnLoopCompleted()
        {
            RemainingDelay = LoopDelay;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(1f);
            TryHandleOverLoops();

            base.OnLoopCompleted();
        }

        protected override void RewoundLoop___xxxxxxxxxx()
        {
            _rawProgress = CompletedLoops - 1;
            base.RewoundLoop___xxxxxxxxxx();
        }

        protected override void OnLoopRewound()
        {
            var delay = CompletedLoops == 1 ? StartDelay : LoopDelay;
            RemainingDelay = delay;
            EvaluateStateBy_xxxxxxxxxxxxxxxx(0f);

            base.OnLoopRewound();
        }

        private void TryHandleOverLoops()
        {
            if (CompletedLoops <= ThresholdOverLoops)
            {
                return;
            }

            _rawProgress %= ThresholdOverLoops;
        }
    }
}