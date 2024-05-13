using System.Collections.Generic;
using System.Linq;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.States;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        #region Initializing

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

        #endregion

        #region Activity

        public bool IsEnabled()
        {
            return Initialized && _activityMachine.InState<EnabledState>();
        }

        public bool IsSleeping()
        {
            return Initialized && _activityMachine.InState<SleepingState>();
        }

        public bool IsDisabled()
        {
            return !Initialized || _activityMachine.InState<DisabledState>();
        }

        #endregion

        #region Handling

        public bool IsRunning()
        {
            return Initialized && _handlingMachine.InState<RunningState>();
        }

        public bool IsPlaying()
        {
            return Initialized && _handlingMachine.InState<PlayingState>();
        }

        public bool IsRewinding()
        {
            return Initialized && _handlingMachine.InState<RewindState>();
        }

        public bool IsPaused()
        {
            return Initialized && _handlingMachine.InState<PauseState>();
        }

        public bool IsStopped()
        {
            return !Initialized || _handlingMachine.InState<StoppedState>();
        }

        public virtual bool IsCompleted()
        {
            return Initialized && CompletedLoops >= LoopCount && !IsRewinding();
        }

        public virtual bool IsCompletable()
        {
            return Initialized && !IsStopped() && !IsCompleted();
        }

        public virtual bool IsRewound()
        {
            return Initialized && CompletedLoops <= 0 && !IsPlaying();
        }
        
        public virtual bool IsRewindable()
        {
            return Initialized && !IsStopped() && !IsRewound();
        }

        #endregion

        #region Triggers

        public bool ContainsTrigger(string tag)
        {
            return _triggers != null && _triggers.Any(t => t.CompareId(tag));
        }

        public bool ContainsTag(object value)
        {
            return _tags != null && _tags.Contains(value);
        }

        public bool ContainsAllTags(IEnumerable<object> values)
        {
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
                return false;
            }

            foreach (var value in values)
            {
                if (!ContainsTag(value))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ContainsAnyTags(IEnumerable<object> values)
        {
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
                return false;
            }

            foreach (var value in values)
            {
                if (ContainsTag(value))
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Mutable

        public bool IsMutable()
        {
            return IsStopped();
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

        #endregion

        #region Misc

        public bool CompletionActionIs<TAction>() where TAction : TweenCoreAction
        {
            return CompletionAction is TAction;
        }

        #endregion
    }
}