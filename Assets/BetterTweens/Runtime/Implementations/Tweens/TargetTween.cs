using System;
using Better.Tweens.Runtime.Triggers;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TargetTween<TTarget, TValue, TValueOptions> : Tween<TValue, TValueOptions>
        where TTarget : class
    {
        private const string TargetTriggerId = nameof(TargetTriggerId);

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

            if (!ValidateMutable(true))
            {
                return this;
            }

            RemoveTag(_target);
            AddTag(value);

            RemoveTriggers(TargetTriggerId);
            if (value is Object unityTarget)
            {
                var destroyObjectCondition = new DestroyObjectCondition(unityTarget);
                AddTrigger<StopTrigger>(destroyObjectCondition, TargetTriggerId);
            }

            _target = value;
            return this;
        }
    }

    [Serializable]
    public abstract class TargetTween<TTarget, TValue> : TargetTween<TTarget, TValue, TValue>
        where TTarget : class
    {
    }

    [Serializable]
    public abstract class TargetTween<TTarget> : TargetTween<TTarget, TTarget>
        where TTarget : class
    {
        protected override TTarget GetCurrentValue()
        {
            return Target;
        }
    }
}