﻿using System;
using System.Collections.Generic;
using Better.Commons.Runtime.Extensions;
using Better.Conditions.Runtime;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Data;
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
            _activityMachine.CurrentState?.Reset();

            return this;
        }

        public TweenCore SetInfinitySleeping()
        {
            _sleepingDuration.OverrideInfinity();
            _activityMachine.CurrentState?.Reset();

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

        public TweenCore SetCompletionAction(ActionType actionType)
        {
            var action = TweenCoreActionUtility.GetActionByType(actionType);
            return SetCompletionAction(action);
        }

        public TweenCore SetCompletionAction<TAction>()
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return SetCompletionAction(action);
        }

        public TweenCore SetRewoundAction(TweenCoreAction value)
        {
            if (ValidationUtility.ValidateNullReference(value))
            {
                _rewoundAction.Override(value);
            }

            return this;
        }

        public TweenCore SetRewoundAction<TAction>()
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return SetRewoundAction(action);
        }

        public TweenCore SetRewoundAction(ActionType actionType)
        {
            var action = TweenCoreActionUtility.GetActionByType(actionType);
            return SetRewoundAction(action);
        }

        #endregion

        #region Events

        public TweenCore OnStateChanged(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                StateChanged += callback;
            }

            return this;
        }

        public TweenCore OnActivityChanged(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                ActivityChanged += callback;
            }

            return this;
        }

        public TweenCore OnEnabled(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Enabled += callback;
            }

            return this;
        }

        public TweenCore OnAsleep(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Asleep += callback;
            }

            return this;
        }

        public TweenCore OnDisabled(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Disabled += callback;
            }

            return this;
        }

        public TweenCore OnStarted(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Started += callback;
            }

            return this;
        }

        public TweenCore OnRunned(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Runned += callback;
            }

            return this;
        }

        public TweenCore OnPlaying(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Playing += callback;
            }

            return this;
        }

        public TweenCore OnRewinding(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Rewinding += callback;
            }

            return this;
        }

        public TweenCore OnUpdated(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Updated += callback;
            }

            return this;
        }

        public TweenCore OnPaused(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Paused += callback;
            }

            return this;
        }

        public TweenCore OnStopped(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Stopped += callback;
            }

            return this;
        }

        public TweenCore OnCompleted(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Completed += callback;
            }

            return this;
        }

        public TweenCore OnRewound(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                Rewound += callback;
            }

            return this;
        }

        public TweenCore OnLoopCompleted(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                LoopCompleted += callback;
            }

            return this;
        }

        public TweenCore OnLoopRewound(Action callback)
        {
            if (ValidationUtility.Validate(callback))
            {
                LoopRewound += callback;
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

        public TweenCore RemoveTriggers(string id)
        {
            return RemoveTriggers(trigger => trigger.CompareId(id));
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

        public TweenCore AddTags(IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return this;
            }

            foreach (var value in values)
            {
                AddTag(value);
            }

            return this;
        }

        public TweenCore RemoveTag(object value)
        {
            _tags?.Remove(value);
            return this;
        }

        public TweenCore RemoveTags(IEnumerable<object> values)
        {
            if (!ValidationUtility.ValidateNullReference(values))
            {
                return this;
            }

            foreach (var value in values)
            {
                RemoveTag(value);
            }

            return this;
        }

        #endregion
    }
}