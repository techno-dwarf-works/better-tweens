namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void OnLoopCompleted()
        {
            EvaluateStateByMode(1f);
            CallbackUtility.InvokeWithSafety(LoopCompleted);

            if (CompletedLoops >= CoreProperties.LoopCount)
            {
                OnCompleted();
            }
            else
            {
                RemainingDelay = CoreProperties.LoopDelay;
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
            CallbackUtility.InvokeWithSafety(LoopRewound);

            if (CompletedLoops <= 0)
            {
                OnRewound();
            }
            else
            {
                RemainingDelay = CoreProperties.LoopDelay;
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