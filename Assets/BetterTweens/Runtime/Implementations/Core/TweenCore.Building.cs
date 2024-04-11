using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using Better.Tweens.Runtime.Logs;
using Better.Tweens.Runtime.Triggers;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class TweenCore
    {
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
                if (value < MinLoopCount)
                {
                    var message = $"{nameof(LoopCount)} cannot be less of {nameof(MinLoopCount)}({MinLoopCount}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinLoopCount;
                }

                _loopCount = value;
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

        #region Events

        public TweenCore OnStarted(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Started += callback;
            }

            return this;
        }

        public TweenCore OnActivated(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Activated += callback;
            }

            return this;
        }

        public TweenCore OnPlaying(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Playing += callback;
            }

            return this;
        }

        public TweenCore OnRewinding(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Rewinding += callback;
            }

            return this;
        }

        public TweenCore OnUpdated(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Updated += callback;
            }

            return this;
        }

        public TweenCore OnPaused(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Paused += callback;
            }

            return this;
        }

        public TweenCore OnStopped(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Stopped += callback;
            }

            return this;
        }

        public TweenCore OnCompleted(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Completed += callback;
            }

            return this;
        }

        public TweenCore OnRewound(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                Rewound += callback;
            }

            return this;
        }

        public TweenCore OnLoopCompleted(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                LoopCompleted += callback;
            }

            return this;
        }

        public TweenCore OnLoopRewound(Action callback)
        {
            if (CallbackUtility.Validate(callback))
            {
                LoopRewound += callback;
            }

            return this;
        }

        #endregion

        #region Triggers

        public TweenCore AddTrigger(Trigger value)
        {
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            if (ValidateMutable(true) && !ContainsTrigger(value))
            {
                _triggers ??= new();
                _triggers.Add(value);
            }

            return this;
        }

        public TweenCore AddTriggers(IEnumerable<Trigger> values)
        {
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            foreach (var value in values)
            {
                AddTrigger(value);
            }

            return this;
        }

        public TweenCore RemoveTrigger(Trigger value)
        {
            if (ValidateMutable(true))
            {
                _triggers?.Remove(value);
            }

            return this;
        }

        public TweenCore RemoveTriggers(IEnumerable<Trigger> values)
        {
            if (values == null)
            {
                var message = $"{nameof(values)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            foreach (var value in values)
            {
                RemoveTrigger(value);
            }

            return this;
        }

        public TweenCore RemoveTriggers<TTrigger>(Predicate<TTrigger> predicate)
            where TTrigger : Trigger
        {
            if (predicate == null)
            {
                var message = $"{nameof(predicate)} cannot be null";
                LogUtility.LogException(message);
                return this;
            }

            if (ValidateMutable(true))
            {
                _triggers?.RemoveWhere(t => t is TTrigger casted && predicate.Invoke(casted));
            }

            return this;
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