namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void OnLoopCompleted()
        {
            EvaluateStateByMode(1f);
            CallbackUtility.InvokeWithSafety(LoopCompleted);

            if (CompletedLoops >= DerivedProperties.LoopCount)
            {
                OnCompleted();
            }
            else
            {
                RemainingDelay = DerivedProperties.LoopDelay;
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
                RemainingDelay = DerivedProperties.LoopDelay;
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