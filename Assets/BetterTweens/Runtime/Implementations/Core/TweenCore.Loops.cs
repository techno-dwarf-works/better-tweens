using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void CompleteLoop()
        {
            if (CompletedLoops >= LoopCount)
            {
                var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be increased";
                LogUtility.LogException(message);
                return;
            }

            CompletedLoops++;
            OnLoopCompleted();
        }

        protected void CompleteLoops(int loopCount)
        {
            for (int i = 0; i < loopCount; i++)
            {
                if (IsStopped() || IsCompleted())
                {
                    return;
                }

                CompleteLoop();
            }
        }

        protected virtual void OnLoopCompleted()
        {
            CheckOverLoops(); // TODO: Re-set state in check?
            ActionUtility.Invoke(LoopCompleted);
            // TODO: change state in event, but not handle this

            if (IsCompleted())
            {
                OnCompleted();
            }
        }

        protected virtual void RewoundLoop___xxxxxxxxxx() // TODO: Name
        {
            if (CompletedLoops <= 0)
            {
                var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be decreased";
                LogUtility.LogException(message);
                return;
            }

            CompletedLoops--;
            OnLoopRewound();
        }

        protected void RewoundLoops______xxxxxxx(int loopCount) // TODO: Name 
        {
            for (int i = 0; i < loopCount; i++)
            {
                if (IsStopped() || IsRewound())
                {
                    return;
                }

                RewoundLoop___xxxxxxxxxx();
            }
        }

        protected virtual void OnLoopRewound()
        {
            ActionUtility.Invoke(LoopRewound);

            if (IsRewound())
            {
                OnRewound();
            }
        }

        private void CheckOverLoops()
        {
            if (CompletedLoops > Data.LoopCount.MaxValue)
            {
                // TODO: Add warning, use infinity
                Stop();
            }
        }
    }
}