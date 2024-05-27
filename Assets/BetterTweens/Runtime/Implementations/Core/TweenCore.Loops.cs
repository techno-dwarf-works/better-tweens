using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        protected virtual void CompleteLoop()
        {
            // TODO: validation ?
            // if (CompletedLoops >= LoopCount)
            // {
            //     var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be increased";
            //     LogUtility.LogException(message);
            //     return;
            // }

            CompletedLoops++;
            OnLoopCompleted();
        }

        protected void CompleteLoops(int loopCount)
        {
            // TODO: handle change state
            for (int i = 0; i < loopCount; i++)
            {
                // TODO: validation ?
                // if (!IsCompletable())
                // {
                //     return;
                // }

                CompleteLoop();
            }
        }

        protected virtual void OnLoopCompleted()
        {
            var rootStateToken = _handlingMachine.CurrentState.Token;

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

        protected virtual void RewoundLoop()
        {
            // TODO: validation ?
            // if (!IsRewindable())
            // {
            //     var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be rewindable";
            //     LogUtility.LogException(message);
            //     return;
            // }

            if (CompletedLoops > 0)
            {
                CompletedLoops--;
            }

            OnLoopRewound();
        }

        protected void RewoundLoops(int loopCount)
        {
            // TODO: handle change state
            for (int i = 0; i < loopCount; i++)
            {
                // TODO: validation ?
                // if (!IsRewindable())
                // {
                //     return;
                // }

                RewoundLoop();
            }
        }

        protected virtual void OnLoopRewound()
        {
            var rootStateToken = _handlingMachine.CurrentState.Token;

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

            var rootStateToken = _handlingMachine.CurrentState.Token;

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