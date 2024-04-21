using System;
using System.Collections.Generic;
using System.Linq;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Triggers;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
        #region Delays

        public TweenCore SetStartDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinDelay)
                {
                    var message = $"{nameof(StartDelay)} cannot be less of {nameof(MinDelay)}({MinDelay}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDelay;
                }

                _startDelay = value;
            }

            return this;
        }

        public TweenCore SetLoopDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinDelay)
                {
                    var message = $"{nameof(LoopDelay)} cannot be less of {nameof(MinDelay)}({MinDelay}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDelay;
                }

                _loopDelay = value;
            }

            return this;
        }

        #endregion

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

        public TweenCore SetLoopMode(LoopMode value)
        {
            if (ValidateMutable(true))
            {
                _loopMode = value;
            }

            return this;
        }

        public TweenCore SetLoops(int count, LoopMode loopMode)
        {
            SetLoopCount(count);
            SetLoopMode(loopMode);

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

        #region Ease

        public TweenCore SetEase(Ease value)
        {
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            if (ValidateMutable(true))
            {
                _ease.Override(value);
            }

            return this;
        }

        public TweenCore SetEase(EaseType type, EaseMode mode = EaseMode.InOut)
        {
            var ease = EaseUtility.GetEaseByType(type, mode);
            return SetEase(ease);
        }

        public TweenCore SetEase(AnimationCurve animationCurve)
        {
            var ease = new CurveEase(animationCurve);
            return SetEase(ease);
        }

        public void SetEase(Func<float, float> func)
        {
            var ease = new FuncEase(func);
            SetEase(ease);
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

        public TweenCore SetCompletionBehaviour(CompletionBehaviourType type)
        {
            var completionBehaviour = CompletionBehaviourTypeUtility.GetBehaviourByType(type);
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

        public TweenCore AddTrigger<TTrigger>(IEnumerable<TriggerCondition> conditions, string tag = Trigger.UndefinedTag)
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

            if (tag.IsNullOrEmpty())
            {
                var message = $"{nameof(conditions)} cannot be null or empty";
                LogUtility.LogWarning(message);
                return this;
            }

            if (ValidateMutable(true))
            {
                var trigger = new TTrigger();
                trigger.Initialize(tag, conditionsSet);

                _triggers ??= new();
                _triggers.Add(trigger);
            }

            return this;
        }

        public TweenCore AddTrigger<TTrigger>(TriggerCondition condition, string tag = Trigger.UndefinedTag)
            where TTrigger : Trigger, new()
        {
            var conditions = new HashSet<TriggerCondition> { condition };
            return AddTrigger<TTrigger>(conditions, tag);
        }

        public TweenCore AddTrigger<TTrigger>(TriggerCondition condition1, TriggerCondition condition2, string tag = Trigger.UndefinedTag)
            where TTrigger : Trigger, new()
        {
            var conditions = new HashSet<TriggerCondition> { condition1, condition2 };
            return AddTrigger<TTrigger>(conditions, tag);
        }

        public TweenCore AddTrigger<TTrigger>(TriggerCondition condition1, TriggerCondition condition2, TriggerCondition condition3, string tag = Trigger.UndefinedTag)
            where TTrigger : Trigger, new()
        {
            var conditions = new HashSet<TriggerCondition> { condition1, condition2, condition3 };
            return AddTrigger<TTrigger>(conditions, tag);
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
                _triggers?.RemoveWhere(t => t.CompareTag(tag));
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

        #region Misc

        public TweenCore SetDuration(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinDuration)
                {
                    var message = $"{nameof(Duration)} cannot be less of {nameof(MinDuration)}({MinDuration}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinDuration;
                }

                _duration = value;
            }

            return this;
        }

        #endregion
    }
}