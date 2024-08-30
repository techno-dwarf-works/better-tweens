using System;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Triggers;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        #region Loops

        public TweenCore SetLoopCount(int value)
        {
            if (ValidateMutable(true))
            {
                _loopCount.SetValue(value);
            }

            return this;
        }

        public TweenCore SetInfinityLoop()
        {
            if (ValidateMutable(true))
            {
                _loopCount.MakeInfinity();
            }

            return this;
        }

        #endregion

        #region Sleeping

        public TweenCore SetSleepingDuration(float value)
        {
            _sleepingDuration.OverrideDuration(value);
            _activityMachine?.CurrentState.Reset();

            return this;
        }

        public TweenCore SetInfinitySleeping()
        {
            _sleepingDuration.OverrideInfinity();
            _activityMachine?.CurrentState.Reset();

            return this;
        }

        #endregion

        #region TimeScale

        public TweenCore DependencyUnityTimeScale(bool depend)
        {
            _dependUnityTimeScale.Override(depend);
            return this;
        }

        public TweenCore DependencyGlobalTimeScale(bool depend)
        {
            _dependGlobalTimeScale.Override(depend);
            return this;
        }

        public TweenCore SetLocalTimeScale(float value)
        {
            _localTimeScale = value;
            return this;
        }

        #endregion

        #region Actions

        public TweenCore SetCompletionAction(TweenCoreAction value)
        {
            if (ValidationUtility.ValidateNullReference(value))
            {
                _completionAction.Override(value);
            }

            return this;
        }

        public TweenCore SetRewoundAction(TweenCoreAction value)
        {
            if (ValidationUtility.ValidateNullReference(value))
            {
                _rewoundAction.Override(value);
            }

            return this;
        }

        #endregion
        
        #region Triggers

        public TweenCore AddTrigger(Trigger trigger)
        {
            if (ValidationUtility.ValidateNullReference(trigger))
            {
                _triggers ??= new();
                _triggers.Add(trigger);
            }

            return this;
        }

        public TweenCore RemoveTriggers(Predicate<Trigger> predicate)
        {
            if (ValidationUtility.ValidateNullReference(predicate))
            {
                _triggers?.RemoveWhere(predicate);
            }

            return this;
        }

        #endregion

        #region Tags

        public TweenCore AddTag(object value)
        {
            if (!ValidationUtility.ValidateNullReference(value))
            {
                return this;
            }

            if (!ContainsTag(value))
            {
                _tags ??= new();
                _tags.Add(value);
            }

            return this;
        }

        public TweenCore RemoveTag(object value)
        {
            _tags?.Remove(value);
            return this;
        }

        #endregion
    }
}