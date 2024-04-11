using System;
using Better.Tweens.Runtime.Logs;
using Better.Tweens.Runtime.Triggers;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TargetTween<TTarget, TValue, TValueOptions> : Tween<TValue, TValueOptions>
        where TTarget : class
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
                RemoveTriggers<Trigger<TTarget>>(t => t.IsSource(_target));
                RemoveTag(_target);

                _target = value;

                var nullTargetTrigger = new NullReferenceTrigger(this, TriggerActionType.Stop, _target);
                AddTrigger(nullTargetTrigger);
                AddTag(_target);
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
        where TTarget : class
    {
    }

    [Serializable]
    public abstract class TargetTween<TValue> : TargetTween<TValue, TValue>
        where TValue : class
    {
        protected override TValue GetCurrentValue()
        {
            return Target;
        }
    }
}