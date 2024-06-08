using System;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Vector4Tween : VectorTween<Vector4, XYZWAxis>
    {
        protected override Vector4 CalculateRelativeFrom(Vector4 to, Vector4 options)
        {
            return to - options;
        }

        protected override Vector4 CalculateTo(Vector4 from, Vector4 options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Vector4 GetRelativeOptions(Vector4 from, Vector4 to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(Vector4 fromValue, Vector4 toValue, float time)
        {
            // TODO: Add Vector4.Slerp to Commons, and update this
            var evaluatedValue = Spherical
                ? Vector4.Lerp(fromValue, toValue, time)
                : Vector4.Lerp(fromValue, toValue, time);

            if (HasConstraints)
            {
                var currentValue = GetCurrentValue();
                for (int i = 0; i < Constraints.Count; i++)
                {
                    var axisIndex = (int)Constraints[i];
                    evaluatedValue[axisIndex] = currentValue[axisIndex];
                }
            }

            SetCurrentValue(evaluatedValue);
        }

        protected abstract void SetCurrentValue(Vector4 value);
    }

    [Serializable]
    public abstract class Vector4Tween<TTarget> : VectorTween<TTarget, Vector4, XYZWAxis>
        where TTarget : class
    {
        protected override Vector4 CalculateRelativeFrom(Vector4 to, Vector4 options)
        {
            return to - options;
        }

        protected override Vector4 CalculateTo(Vector4 from, Vector4 options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Vector4 GetRelativeOptions(Vector4 from, Vector4 to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(Vector4 fromValue, Vector4 toValue, float time)
        {
            // TODO: Add Vector4.Slerp to Commons, and update this
            var evaluatedValue = Spherical
                ? Vector4.Lerp(fromValue, toValue, time)
                : Vector4.Lerp(fromValue, toValue, time);

            if (HasConstraints)
            {
                var currentValue = GetCurrentValue();
                for (int i = 0; i < Constraints.Count; i++)
                {
                    var axisIndex = (int)Constraints[i];
                    evaluatedValue[axisIndex] = currentValue[axisIndex];
                }
            }

            SetCurrentValue(evaluatedValue);
        }

        protected abstract void SetCurrentValue(Vector4 value);
    }
}