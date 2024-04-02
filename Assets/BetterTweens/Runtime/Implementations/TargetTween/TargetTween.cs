using System;
using Better.Tweens.Runtime.Properties;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TargetTween<TTarget, TProperties, TValue, TValueOptions> : Tween<TProperties, TValue, TValueOptions>
        where TProperties : TargetTweenProperties<TTarget, TValue>, new()
    {
        public TargetTween<TTarget, TProperties, TValue, TValueOptions> SetTarget(TTarget value)
        {
            if (ValidateMutable(true))
            {
                Properties.Target = value;
            }

            return this;
        }
    }

    [Serializable]
    public abstract class TargetTween<TTarget, TValue, TValueOptions> : TargetTween<TTarget, TargetTweenProperties<TTarget, TValue>, TValue, TValueOptions>
    {
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
            return Properties.Target;
        }
    }
}