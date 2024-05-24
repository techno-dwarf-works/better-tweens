using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public abstract partial class ProgressableCore
    {
        #region Delays

        public TweenCore SetLoopDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinTime)
                {
                    var message = $"{nameof(LoopDelay)} cannot be less of {nameof(MinTime)}({MinTime}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinTime;
                }

                _loopDelay = value;
            }

            return this;
        }

        public TweenCore SetStartDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinTime)
                {
                    var message = $"{nameof(StartDelay)} cannot be less of {nameof(MinTime)}({MinTime}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinTime;
                }

                _startDelay = value;
            }

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

        #region Misc

        public TweenCore SetDuration(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < MinTime)
                {
                    var message = $"{nameof(Duration)} cannot be less of {nameof(MinTime)}({MinTime}), was clamped";
                    LogUtility.LogWarning(message);
                    value = MinTime;
                }

                _duration = value;
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

        #endregion
    }
}