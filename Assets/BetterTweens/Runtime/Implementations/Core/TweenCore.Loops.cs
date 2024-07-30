using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public virtual bool InstantCompleteLoop()
        {
            if (!IsCompletable())
            {
                return false;
            }

            CompletedLoops++;
            OnLoopCompleted();

            return true;
        }

        public bool InstantCompleteLoops(int loopCount)
        {
            var rootStateToken = GetHandlingStateToken();
            for (int i = 0; i < loopCount; i++)
            {
                if (!InstantCompleteLoop())
                {
                    return false;
                }

                if (rootStateToken.IsCancellationRequested)
                {
                    return false;
                }
            }

            return true;
        }

        protected virtual void OnLoopCompleted()
        {
            var rootStateToken = GetHandlingStateToken();
            ActionUtility.TryInvokeBySafe(LoopCompleted);
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

        public virtual bool InstantRewoundLoop()
        {
            if (CompletedLoops <= 0)
            {
                CompletedLoops--;
            }

            OnLoopRewound();
            return true;
        }

        public bool InstantRewoundLoops(int loopCount)
        {
            var rootStateToken = GetHandlingStateToken();
            for (int i = 0; i < loopCount; i++)
            {
                if (!InstantRewoundLoop())
                {
                    return false;
                }

                if (rootStateToken.IsCancellationRequested)
                {
                    return false;
                }
            }

            return true;
        }

        protected virtual void OnLoopRewound()
        {
            var rootStateToken = GetHandlingStateToken();

            ActionUtility.TryInvokeBySafe(LoopRewound);
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
            if (CompletedLoops <= OverLoopsThreshold)
            {
                return;
            }

            if (InfinityLoops)
            {
                CompletedLoops %= OverLoopsThreshold;
                return;
            }

            var message = $"{nameof(CompletedLoops)}({CompletedLoops}) is overlooped: handling, try will restart with infinity loops...";
            LogUtility.LogWarning(message, this);

            Stop();
            if (!IsStopped())
            {
                return;
            }

            SetInfinityLoop();
            Play();
        }
    }
}