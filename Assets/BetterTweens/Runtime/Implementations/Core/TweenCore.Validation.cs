using System;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        public bool IsActive()
        {
            return Initialized && _stateMachine.InState<ActiveState>();
        }

        public bool IsPlaying()
        {
            return Initialized && _stateMachine.InState<PlayingState>();
        }

        public bool IsRewinding()
        {
            return Initialized && _stateMachine.InState<RewindState>();
        }

        public bool IsPaused()
        {
            return Initialized && _stateMachine.InState<PauseState>();
        }

        public bool IsStopped()
        {
            return !Initialized || _stateMachine.InState<StoppedState>();
        }

        public bool IsMutable()
        {
            return IsStopped();
        }

        private bool IsInitializable()
        {
#if UNITY_EDITOR
            return Application.isPlaying;
#endif

            return true;
        }

        protected bool ValidateInitialized(bool targetState, bool logError = true)
        {
            var isValid = Initialized == targetState;
            if (!isValid && logError)
            {
                var reason = targetState ? "must be initialized" : "must be non-initialized";
                var message = "Not valid, " + reason;
                LogUtility.LogError(message);
            }

            return isValid;
        }

        protected bool ValidateMutable(bool targetState, bool logError = true)
        {
            var isMutable = IsMutable();
            var isValid = isMutable == targetState;
            if (!isValid && logError)
            {
                var reason = targetState ? "must be mutable" : "must be immutable";
                var message = "Not valid, " + reason;
                LogUtility.LogError(message);
            }

            return isValid;
        }
    }
}