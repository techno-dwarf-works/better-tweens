﻿using Better.StateMachine.Runtime;
using Better.StateMachine.Runtime.Modules.Snapshot;
using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

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
            // TODO: handle change state
            for (int i = 0; i < loopCount; i++)
            {
                if (!IsCompletable())
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
            if (!IsRewindable())
            {
                var message = $"{nameof(CompletedLoops)}({CompletedLoops}) cannot be rewindable";
                LogUtility.LogException(message);
                return;
            }

            CompletedLoops--;
            CompletedLoops = Mathf.Max(CompletedLoops, 0);

            OnLoopRewound();
        }

        protected void RewoundLoops(int loopCount)
        {
            // TODO: handle change state
            for (int i = 0; i < loopCount; i++)
            {
                if (!IsRewindable())
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
            if (CompletedLoops <= Data.LoopCount.MaxValue)
            {
                return;
            }

            var message = $"Overloops({nameof(CompletedLoops)}: {CompletedLoops}) handling, try will restart with infinity loops...";
            LogUtility.LogWarning(message);

            var snapshotModule = _handlingMachine.GetModule<HandlingState, SnapshotModule<HandlingState>>();
            var snapshotToken = snapshotModule.CreateToken();

            Stop();
            if (snapshotToken.HasChanges)
            {
                return;
            }

            SetInfinityLoop();
            Play();
        }
    }
}