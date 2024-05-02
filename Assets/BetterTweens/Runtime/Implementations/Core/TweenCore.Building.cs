using System;
using System.Collections.Generic;
using System.Linq;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Logs;
using Better.Tweens.Runtime.Triggers;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

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
            _sleepingDuration.SetValue(value);
            _activityMachine.CurrentState?.Reset();

            return this;
        }

        public TweenCore SetInfinitySleeping()
        {
            _loopCount.MakeInfinity();
            _activityMachine.CurrentState?.Reset();

            return this;
        }

        #endregion

        #region TimeScale

        public TweenCore DependencyUnityTimeScale(bool depend)
        {
            if (ValidateMutable(true))
            {
                _dependUnityTimeScale.Override(depend);
            }

            return this;
        }

        public TweenCore DependencyGlobalTimeScale(bool value)
        {
            if (ValidateMutable(true))
            {
                _dependGlobalTimeScale.Override(value);
            }

            return this;
        }

        public TweenCore SetLocalTimeScale(float value)
        {
            _localTimeScale = value;
            return this;
        }

        #endregion

        #region CompletionBehaviour

        public TweenCore SetCompletionBehaviour(CompletionBehaviour value)
        {
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            if (ValidateMutable(true))
            {
                _completionBehaviour.Override(value);
            }

            return this;
        }

        public TweenCore SetCompletionBehaviour<TBehaviour>()
            where TBehaviour : CompletionBehaviour, new()
        {
            var completionBehaviour = new TBehaviour();
            return SetCompletionBehaviour(completionBehaviour);
        }

        public TweenCore SetCompletionBehaviour(CompletionType type)
        {
            var completionBehaviour = CompletionBehaviourUtility.GetBehaviourByType(type);
            return SetCompletionBehaviour(completionBehaviour);
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

        public TweenCore AddTrigger<TTrigger>(IEnumerable<TriggerCondition> conditions, string id = Trigger.UndefinedId)
            where TTrigger : Trigger, new()
        {
            if (conditions == null)
            {
                var message = $"{nameof(conditions)} cannot be null";
                LogUtility.LogWarning(message);
                return this;
            }

            var conditionsSet = conditions.ToHashSet();
            if (conditionsSet.IsEmpty())
            {
                var message = $"{nameof(conditions)} cannot be empty";
                LogUtility.LogWarning(message);
                return this;
            }

            if (id.IsNullOrEmpty())
            {
                var message = $"{nameof(conditions)} cannot be null or empty";
                LogUtility.LogWarning(message);
                return this;
            }

            if (ValidateMutable(true))
            {
                var trigger = new TTrigger();
                trigger.Initialize(id, conditionsSet);

                _triggers ??= new();
                _triggers.Add(trigger);
            }

            return this;
        }

        public TweenCore AddTrigger<TTrigger>(TriggerCondition condition, string id = Trigger.UndefinedId)
            where TTrigger : Trigger, new()
        {
            var conditions = new HashSet<TriggerCondition> { condition };
            return AddTrigger<TTrigger>(conditions, id);
        }

        public TweenCore AddTrigger<TTrigger>(TriggerCondition condition1, TriggerCondition condition2, string id = Trigger.UndefinedId)
            where TTrigger : Trigger, new()
        {
            var conditions = new HashSet<TriggerCondition> { condition1, condition2 };
            return AddTrigger<TTrigger>(conditions, id);
        }

        public TweenCore AddTrigger<TTrigger>(TriggerCondition condition1, TriggerCondition condition2, TriggerCondition condition3, string id = Trigger.UndefinedId)
            where TTrigger : Trigger, new()
        {
            var conditions = new HashSet<TriggerCondition> { condition1, condition2, condition3 };
            return AddTrigger<TTrigger>(conditions, id);
        }

        public TweenCore RemoveTriggers<TTrigger>()
            where TTrigger : Trigger
        {
            if (ValidateMutable(true))
            {
                _triggers?.RemoveWhere(t => t is TTrigger);
            }

            return this;
        }

        public TweenCore RemoveTriggers(string tag)
        {
            if (tag.IsNullOrEmpty())
            {
                var message = $"{nameof(tag)} cannot be null or empty";
                LogUtility.LogException(message);
                return this;
            }

            if (ValidateMutable(true))
            {
                _triggers?.RemoveWhere(t => t.CompareId(tag));
            }

            return this;
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

            if (ValidateMutable(true) && !ContainsTag(value))
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
            if (ValidateMutable(true))
            {
                _tags?.Remove(value);
            }

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