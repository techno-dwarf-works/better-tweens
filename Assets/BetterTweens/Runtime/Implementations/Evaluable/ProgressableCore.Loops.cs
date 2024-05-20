using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        protected override void OnLoopCompleted()
        {
            EvaluateStateByLoop(1f);
            RemainingDelay = LoopDelay;

            LoopProgress = Mathf.Min(1f, LoopProgress);
            LoopProgress -= 1f;
            
            base.OnLoopCompleted();
        }

        protected override void OnLoopRewound()
        {
            EvaluateStateByLoop(0f);
            RemainingDelay = CompletedLoops == 1 ? StartDelay : LoopDelay;
 
            if (CompletedLoops == 0)
            {
                LoopProgress = 0f;
            }
            else
            {
                LoopProgress += 1f;
                LoopProgress = Mathf.Min(LoopProgress, 1f);
            }

            base.OnLoopRewound();
        }
    }
}