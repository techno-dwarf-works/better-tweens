using System;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Vector3Tween : VectorTween<Vector3, XYZAxis>
    {
        protected override Vector3 CalculateRelativeFrom(Vector3 to, Vector3 options)
        {
            return to - options;
        }

        protected override Vector3 CalculateTo(Vector3 from, Vector3 options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Vector3 GetRelativeOptions(Vector3 from, Vector3 to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(Vector3 fromValue, Vector3 toValue, float time)
        {
            var evaluatedValue = Spherical
                ? Vector3.Slerp(fromValue, toValue, time)
                : Vector3.Lerp(fromValue, toValue, time);

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

        protected abstract void SetCurrentValue(Vector3 value);
    }

    [Serializable]
    public abstract class Vector3Tween<TTarget> : VectorTween<TTarget, Vector3, XYZAxis>
        where TTarget : class
    {
        protected override Vector3 CalculateRelativeFrom(Vector3 to, Vector3 options)
        {
            return to - options;
        }

        protected override Vector3 CalculateTo(Vector3 from, Vector3 options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => from + options * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Vector3 GetRelativeOptions(Vector3 from, Vector3 to)
        {
            return to - from;
        }

        protected sealed override void EvaluateState(Vector3 fromValue, Vector3 toValue, float time)
        {
            var evaluatedValue = Spherical
                ? Vector3.Slerp(fromValue, toValue, time)
                : Vector3.Lerp(fromValue, toValue, time);

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

        protected abstract void SetCurrentValue(Vector3 value);
    }
}