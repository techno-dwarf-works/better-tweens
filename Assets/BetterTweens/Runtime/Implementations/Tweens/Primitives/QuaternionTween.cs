using System;
using Better.Commons.Runtime.Extensions;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class QuaternionTween : Tween<Quaternion>
    {
        [SerializeField] private bool _spherical;
        public bool Spherical => _spherical;

        public QuaternionTween SetSpherical(bool spherical = true)
        {
            _spherical = spherical;
            return this;
        }

        protected override Quaternion CalculateRelativeFrom(Quaternion to, Quaternion options)
        {
            return to * Quaternion.Inverse(options);
        }

        protected override Quaternion CalculateTo(Quaternion from, Quaternion options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from * options,
                OptionsMode.Speed => from * options.Scale(Duration),
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Quaternion GetRelativeOptions(Quaternion from, Quaternion to)
        {
            return to * Quaternion.Inverse(from);
        }

        protected sealed override void EvaluateState(Quaternion fromValue, Quaternion toValue, float time)
        {
            var value = Spherical
                ? Quaternion.Lerp(fromValue, toValue, time)
                : Quaternion.Slerp(fromValue, toValue, time);

            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(Quaternion value);
    }

    [Serializable]
    public abstract class QuaternionTween<TTarget> : TargetTween<TTarget, Quaternion>
        where TTarget : class
    {
        [SerializeField] private bool _spherical;
        public bool Spherical => _spherical;

        public QuaternionTween<TTarget> SetSpherical(bool spherical = true)
        {
            _spherical = spherical;
            return this;
        }

        protected override Quaternion CalculateRelativeFrom(Quaternion to, Quaternion options)
        {
            return to * Quaternion.Inverse(options);
        }

        protected override Quaternion CalculateTo(Quaternion from, Quaternion options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from * options,
                OptionsMode.Speed => from * options.Scale(Duration),
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override Quaternion GetRelativeOptions(Quaternion from, Quaternion to)
        {
            return to * Quaternion.Inverse(from);
        }

        protected sealed override void EvaluateState(Quaternion fromValue, Quaternion toValue, float time)
        {
            var value = Spherical
                ? Quaternion.Lerp(fromValue, toValue, time)
                : Quaternion.Slerp(fromValue, toValue, time);

            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(Quaternion value);
    }
}