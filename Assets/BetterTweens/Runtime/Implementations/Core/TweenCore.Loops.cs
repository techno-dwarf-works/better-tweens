using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public virtual void InstantCompleteLoop()
        {
            if (!IsCompletable())
            {
                var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be completed";
                LogUtility.LogException(message);
                return;
            }

            CompletedLoops++;
            OnLoopCompleted();
        }

        public void InstantCompleteLoops(int loopCount)
        {
            var rootStateToken = GetHandlingStateToken();
            for (int i = 0; i < loopCount; i++)
            {
                InstantCompleteLoop();

                if (rootStateToken.IsCancellationRequested)
                {
                    return;
                }
            }
        }

        protected virtual void OnLoopCompleted()
        {
            var rootStateToken = GetHandlingStateToken();

            ActionUtility.Invoke(LoopCompleted);
            HandleOverLoops();
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            if (IsCompleted())
            {
                OnCompleted();
            }
        }

        public virtual void InstantRewoundLoop()
        {
            if (CompletedLoops > 0)
            {
                CompletedLoops--;
            }

            OnLoopRewound();
        }

        public void InstantRewoundLoops(int loopCount)
        {
            var rootStateToken = GetHandlingStateToken();
            for (int i = 0; i < loopCount; i++)
            {
                InstantRewoundLoop();

                if (rootStateToken.IsCancellationRequested)
                {
                    return;
                }
            }
        }

        protected virtual void OnLoopRewound()
        {
            var rootStateToken = GetHandlingStateToken();

            ActionUtility.Invoke(LoopRewound);
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            if (IsRewound())
            {
                OnRewound();
            }
        }

        private void HandleOverLoops()
        {
            // TODO: Check it. Completed loops it increase_able when infinity, etc

            if (CompletedLoops <= Data.LoopCount.MaxValue)
            {
                return;
            }

            var message = $"Overloops({nameof(CompletedLoops)}: {CompletedLoops}) handling, try will restart with infinity loops...";
            LogUtility.LogWarning(message);

            var rootStateToken = GetHandlingStateToken();

            Stop();
            if (rootStateToken.IsCancellationRequested)
            {
                return;
            }

            SetInfinityLoop();
            Play();
        }
    }
}