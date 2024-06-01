using System;
using System.Collections.Generic;
using Better.Commons.Runtime.Extensions;
using Better.Conditions.Runtime;
using Better.Tweens.Runtime.Actions;
using Better.Tweens.Runtime.Data;
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
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            _completionAction.Override(value);
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
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            _rewoundAction.Override(value);
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
            if (ActionUtility.Validate(callback))
            {
                StateChanged += callback;
            }

            return this;
        }

        public TweenCore OnActivityChanged(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                ActivityChanged += callback;
            }

            return this;
        }

        public TweenCore OnEnabled(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Enabled += callback;
            }

            return this;
        }

        public TweenCore OnAsleep(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Asleep += callback;
            }

            return this;
        }

        public TweenCore OnDisabled(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Disabled += callback;
            }

            return this;
        }

        public TweenCore OnStarted(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Started += callback;
            }

            return this;
        }

        public TweenCore OnRunned(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Runned += callback;
            }

            return this;
        }

        public TweenCore OnPlaying(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Playing += callback;
            }

            return this;
        }

        public TweenCore OnRewinding(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Rewinding += callback;
            }

            return this;
        }

        public TweenCore OnUpdated(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Updated += callback;
            }

            return this;
        }

        public TweenCore OnPaused(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Paused += callback;
            }

            return this;
        }

        public TweenCore OnStopped(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Stopped += callback;
            }

            return this;
        }

        public TweenCore OnCompleted(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Completed += callback;
            }

            return this;
        }

        public TweenCore OnRewound(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                Rewound += callback;
            }

            return this;
        }

        public TweenCore OnLoopCompleted(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                LoopCompleted += callback;
            }

            return this;
        }

        public TweenCore OnLoopRewound(Action callback)
        {
            if (ActionUtility.Validate(callback))
            {
                LoopRewound += callback;
            }

            return this;
        }

        #endregion

        #region Triggers

        public TweenCore AddTrigger(Trigger trigger)
        {
            if (trigger == null)
            {
                var message = $"{nameof(trigger)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            _triggers ??= new();
            _triggers.Add(trigger);

            return this;
        }

        public TweenCore AddTrigger(TweenCoreAction action, Condition condition, string id = Trigger.UndefinedId)
        {
            if (id.IsNullOrEmpty())
            {
                var message = $"{nameof(id)} cannot be null or empty";
                LogUtility.LogException(message);
                return this;
            }

            if (action == null)
            {
                var message = $"{nameof(action)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            if (condition == null)
            {
                var message = $"{nameof(condition)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            var trigger = new Trigger(id, action, condition);
            return AddTrigger(trigger);
        }

        public TweenCore AddTrigger<TAction>(Condition condition, string id = Trigger.UndefinedId)
            where TAction : TweenCoreAction, new()
        {
            var action = new TAction();
            return AddTrigger(action, condition, id);
        }

        public TweenCore AddTrigger<TAction, TCondition>(string id = Trigger.UndefinedId)
            where TAction : TweenCoreAction, new()
            where TCondition : Condition, new()
        {
            var condition = new TCondition();
            return AddTrigger<TAction>(condition, id);
        }

        public TweenCore RemoveTriggers(Predicate<Trigger> predicate)
        {
            if (predicate == null)
            {
                var message = $"{nameof(predicate)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            _triggers?.RemoveWhere(predicate);
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
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
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
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
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
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
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