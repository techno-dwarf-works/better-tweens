using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class IntTween : Tween<int>
    {
        protected override int CalculateRelativeFrom(int to, int options)
        {
            return to - options;
        }

        protected override int CalculateTo(int from, int options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => Mathf.RoundToInt(from + options * Duration),
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override int GetRelativeOptions(int from, int to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(int fromValue, int toValue, float time)
        {
            var value = (int)Mathf.Lerp(fromValue, toValue, time);
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(int value);
    }

    [Serializable]
    public abstract class IntTween<TTarget> : TargetTween<TTarget, int>
        where TTarget : class
    {
        protected override int CalculateRelativeFrom(int to, int options)
        {
            return to - options;
        }

        protected override int CalculateTo(int from, int options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => Mathf.RoundToInt(from + options * Duration),
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override int GetRelativeOptions(int from, int to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(int fromValue, int toValue, float time)
        {
            var value = (int)Mathf.Lerp(fromValue, toValue, time);
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(int value);
    }
}