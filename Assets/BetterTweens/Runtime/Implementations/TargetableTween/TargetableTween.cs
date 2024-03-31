using System;
using Better.Tweens.Runtime.Properties;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TargetableTween<TTarget, TProperties, TValue, TValueOptions> : Tween<TProperties, TValue, TValueOptions>
        where TProperties : TargetableTweenProperties<TTarget>, new()
    {
        public TargetableTween<TTarget, TProperties, TValue, TValueOptions> SetTarget(TTarget value)
        {
            if (ValidateMutable(true))
            {
                Properties.Target = value;
            }

            return this;
        }
    }

    [Serializable]
    public abstract class TargetableTween<TTarget, TValue, TValueOptions> : TargetableTween<TTarget, TargetableTweenProperties<TTarget>, TValue, TValueOptions>
    {
    }

    [Serializable]
    public abstract class TargetableTween<TTarget, TValue> : TargetableTween<TTarget, TValue, TValue>
    {
    }

    [Serializable]
    public abstract class TargetableTween<TValue> : TargetableTween<TValue, TValue>
    {
        protected override TValue GetCurrentValue()
        {
            return Properties.Target;
        }
    }
}