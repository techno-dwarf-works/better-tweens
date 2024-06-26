﻿using System.Linq;
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
#else
            return true;
#endif
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

        public virtual bool IsEnabled()
        {
            return Initialized && _activityMachine.InState<EnabledState>();
        }

        public virtual bool IsSleeping()
        {
            return Initialized && _activityMachine.InState<SleepingState>();
        }

        public virtual bool IsDisabled()
        {
            return !Initialized || _activityMachine.InState<DisabledState>();
        }

        #endregion

        #region Handling

        public virtual bool IsRunnable()
        {
            return Initialized && !IsBroken();
        }

        public virtual bool IsRunning()
        {
            return Initialized && _handlingMachine.InState<RunningState>();
        }

        public virtual bool IsPlayable()
        {
            if (!IsRunnable())
            {
                return false;
            }

            return !IsCompleted() || IsStopped();
        }

        public virtual bool IsPlaying()
        {
            return Initialized && _handlingMachine.InState<PlayingState>();
        }

        public virtual bool IsRewindable()
        {
            return IsRunnable() && !IsStopped() && !IsRewound();
        }

        public virtual bool IsRewinding()
        {
            return Initialized && _handlingMachine.InState<RewindState>();
        }

        public virtual bool IsRewound()
        {
            return Initialized && CompletedLoops <= 0;
        }

        public virtual bool IsPausable()
        {
            return !IsStopped();
        }

        public virtual bool IsPaused()
        {
            return Initialized && _handlingMachine.InState<PauseState>();
        }

        public virtual bool IsStoppable()
        {
            return true;
        }

        public virtual bool IsStopped()
        {
            return !Initialized || _handlingMachine.InState<StoppedState>();
        }

        public virtual bool IsCompletable()
        {
            return IsRunnable() && !IsStopped() && !IsCompleted() && !IsBroken();
        }

        public virtual bool IsCompleted()
        {
            return Initialized && CompletedLoops >= LoopCount;
        }

        #endregion

        #region Triggers

        public bool ContainsTriggerWith(string id)
        {
            return _triggers != null && _triggers.Any(t => t.CompareId(id));
        }

        public bool ContainsTag(object value)
        {
            return _tags != null && _tags.Contains(value);
        }

        #endregion

        #region Mutable

        public virtual bool IsMutable()
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

        #region Actions

        public bool CompletionActionIs<TAction>()
            where TAction : TweenCoreAction
        {
            return _completionAction.Value is TAction;
        }

        public bool RewoundActionIs<TAction>()
            where TAction : TweenCoreAction
        {
            return _rewoundAction.Value is TAction;
        }

        #endregion

        #region Broken

        public virtual bool IsBroken()
        {
            return false;
        }

        protected bool ValidateBroken(bool targetState, bool logError = true)
        {
            var isBroken = IsBroken();
            var isValid = isBroken == targetState;
            if (!isValid && logError)
            {
                var reason = targetState ? "must be broken" : "must not be broken";
                var message = "Not valid, " + reason;
                LogUtility.LogError(message, this);
            }

            return isValid;
        }

        #endregion
    }
}