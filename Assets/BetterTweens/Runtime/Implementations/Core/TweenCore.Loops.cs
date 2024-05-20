using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules.Snapshot;
using Better.Tweens.Runtime.States;
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
            var snapshotModule = _handlingMachine.GetModule<HandlingState, SnapshotModule<HandlingState>>();
            var snapshotToken = snapshotModule.CreateToken();

            ActionUtility.Invoke(LoopCompleted);
            HandleOverLoops();
            if (snapshotToken.HasChanges)
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
            if (CompletedLoops <= 0)
            {
                var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be decreased";
                LogUtility.LogException(message);
                return;
            }

            CompletedLoops--;
            OnLoopRewound();
        }

        protected void RewoundLoops(int loopCount)
        {
            for (int i = 0; i < loopCount; i++)
            {
                if (IsStopped() || IsRewound())
                {
                    return;
                }

                RewoundLoop();
            }
        }

        protected virtual void OnLoopRewound()
        {
            var snapshotModule = _handlingMachine.GetModule<HandlingState, SnapshotModule<HandlingState>>();
            var snapshotToken = snapshotModule.CreateToken();

            ActionUtility.Invoke(LoopRewound);
            if (snapshotToken.HasChanges)
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
            if (CompletedLoops > Data.LoopCount.MaxValue)
            {
                // TODO: Add warning, use infinity
                Stop();
            }
        }
    }
}