using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void OnLoopCompleted()
        {
            EvaluateStateByMode(1f);
            TryHandleOverLoops();
            ActionUtility.Invoke(LoopCompleted);

            if (IsCompleted())
            {
                OnCompleted();
            }
            else
            {
                RemainingDelay = LoopDelay;
            }
        }

        protected void OnLoopsCompleted(int count)
        {
            for (int i = 0; i < count; i++)
            {
                OnLoopCompleted();
            }
        }

        protected virtual void OnLoopRewound()
        {
            EvaluateStateByMode(0f);
            ActionUtility.Invoke(LoopRewound);

            if (IsRewound())
            {
                OnRewound();
            }
            else
            {
                var delay = CompletedLoops == 1 ? StartDelay : _loopDelay;
                RemainingDelay = delay;
            }
        }

        protected void OnLoopsRewound(int count)
        {
            for (int i = 0; i < count; i++)
            {
                OnLoopRewound();
            }
        }
    }
}