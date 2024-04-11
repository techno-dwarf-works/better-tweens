namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void OnLoopCompleted()
        {
            EvaluateStateByMode(1f);
            CallbackUtility.Invoke(LoopCompleted);

            if (CompletedLoops >= LoopCount)
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
            CallbackUtility.Invoke(LoopRewound);

            if (CompletedLoops <= 0)
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