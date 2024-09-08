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
                if (value < TweensSettings.MinTime)
                {
                    var message = $"{nameof(LoopDelay)} cannot be less of {nameof(TweensSettings.MinTime)}({TweensSettings.MinTime}), was clamped";
                    LogUtility.LogWarning(message);
                    value = TweensSettings.MinTime;
                }

                _loopDelay = value;
            }

            return this;
        }

        public TweenCore SetStartDelay(float value)
        {
            if (ValidateMutable(true))
            {
                if (value < TweensSettings.MinTime)
                {
                    var message = $"{nameof(StartDelay)} cannot be less of {nameof(TweensSettings.MinTime)}({TweensSettings.MinTime}), was clamped";
                    LogUtility.LogWarning(message);
                    value = TweensSettings.MinTime;
                }

                _startDelay = value;
            }

            return this;
        }

        #endregion

        #region Ease

        public TweenCore SetEase(Ease value)
        {
            if (!ValidationUtility.ValidateNullReference(value))
            {
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
                if (value < TweensSettings.MinTime)
                {
                    var message = $"{nameof(Duration)} cannot be less of {nameof(TweensSettings.MinTime)}({TweensSettings.MinTime}), was clamped";
                    LogUtility.LogWarning(message);
                    value = TweensSettings.MinTime;
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

        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is ProgressableCore progressableSource)
            {
                _duration = progressableSource._duration;
                _startDelay = progressableSource._startDelay;
                _loopDelay = progressableSource._loopDelay;
                _loopMode = progressableSource._loopMode;
                _ease = progressableSource._ease.Clone();
            }

            return base.As(source);
        }

        #endregion
    }
}