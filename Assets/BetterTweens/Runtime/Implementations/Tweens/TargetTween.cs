using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class TargetTween<TTarget, TValue, TValueOptions> : Tween<TValue, TValueOptions>
        where TTarget : class
    {
        [SerializeField] private TTarget _target;
        protected TTarget Target => _target;

        protected override void OnInitialized()
        {
            RemoveTagDependency();
            AddTagDependency();

            base.OnInitialized();
        }

        public TargetTween<TTarget, TValue, TValueOptions> SetTarget(TTarget value)
        {
            if (!ValidationUtility.ValidateNullReference(value))
            {
                return this;
            }

            if (ValidateMutable(true))
            {
                OnTargetPreChanged();
                _target = value;
                OnTargetChanged();
            }

            return this;
        }

        protected virtual void OnTargetPreChanged()
        {
            RemoveTagDependency();
        }

        protected virtual void OnTargetChanged()
        {
            AddTagDependency();
        }

        private void AddTagDependency()
        {
            AddTag(Target);
        }

        private void RemoveTagDependency()
        {
            RemoveTag(Target);
        }

        public override bool IsBroken()
        {
            return base.IsBroken() || Target == null;
        }

        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is TargetTween<TTarget> targetTween)
            {
                _target = targetTween._target;
            }

            return base.As(source);
        }
    }

    [Serializable]
    public abstract class TargetTween<TTarget, TValue> : TargetTween<TTarget, TValue, TValue>
        where TTarget : class
    {
        // TODO: Add Button SaveCurrent for "smart" setup
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