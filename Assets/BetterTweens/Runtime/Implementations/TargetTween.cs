using System;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TargetTween<TTarget, TValue, TValueOptions> : Tween<TValue, TValueOptions>
    {
        [SerializeField] private TTarget _target;
        protected TTarget Target => _target;

        public TargetTween<TTarget, TValue, TValueOptions> SetTarget(TTarget value)
        {
            if (value == null)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);

                return this;
            }

            if (ValidateMutable(true))
            {
                _target = value;
            }

            return this;
        }

        protected sealed override void EvaluateState(TValue fromValue, TValue toValue, float time)
        {
            EvaluateState(_target, fromValue, toValue, time);
        }

        protected abstract void EvaluateState(TTarget target, TValue fromValue, TValue toValue, float time);
    }

    [Serializable]
    public abstract class TargetTween<TTarget, TValue> : TargetTween<TTarget, TValue, TValue>
    {
    }

    [Serializable]
    public abstract class TargetTween<TValue> : TargetTween<TValue, TValue>
    {
        protected override TValue GetCurrentValue()
        {
            return Target;
        }
    }
}