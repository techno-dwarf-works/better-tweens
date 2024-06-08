using System;
using Better.Commons.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Vector2Tween : VectorTween<Vector2, Vector2Axis>
    {
        protected override Vector2 CalculateRelativeFrom(Vector2 to, Vector2 options)
        {
            return to - options;
        }

        protected override Vector2 CalculateTo(Vector2 from, Vector2 options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Vector2 GetRelativeOptions(Vector2 from, Vector2 to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(Vector2 fromValue, Vector2 toValue, float time)
        {
            // TODO: Add Vector2.Slerp to Commons, and update this
            var evaluatedValue = Spherical
                ? Vector2.Lerp(fromValue, toValue, time)
                : Vector2.Lerp(fromValue, toValue, time);

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

        protected abstract void SetCurrentValue(Vector2 value);
    }

    [Serializable]
    public abstract class Vector2Tween<TTarget> : VectorTween<TTarget, Vector2, Vector2Axis>
        where TTarget : class
    {
        protected override Vector2 CalculateRelativeFrom(Vector2 to, Vector2 options)
        {
            return to - options;
        }

        protected override Vector2 CalculateTo(Vector2 from, Vector2 options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Vector2 GetRelativeOptions(Vector2 from, Vector2 to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(Vector2 fromValue, Vector2 toValue, float time)
        {
            // TODO: Add Vector2.Slerp to Commons, and update this
            var evaluatedValue = Spherical
                ? Vector2.Lerp(fromValue, toValue, time)
                : Vector2.Lerp(fromValue, toValue, time);

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

        protected abstract void SetCurrentValue(Vector2 value);
    }
}