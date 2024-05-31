using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class FloatTween : Tween<float>
    {
        protected override float CalculateRelativeFrom(float to, float options)
        {
            return to - options;
        }

        protected override float CalculateTo(float from, float options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override float GetRelativeOptions(float from, float to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(float fromValue, float toValue, float time)
        {
            var value = Mathf.Lerp(fromValue, toValue, time);
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(float value);
    }

    [Serializable]
    public abstract class FloatTween<TTarget> : TargetTween<TTarget, float>
        where TTarget : class
    {
        protected override float CalculateRelativeFrom(float to, float options)
        {
            return to - options;
        }

        protected override float CalculateTo(float from, float options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override float GetRelativeOptions(float from, float to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(float fromValue, float toValue, float time)
        {
            var value = Mathf.Lerp(fromValue, toValue, time);
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(float value);
    }
}