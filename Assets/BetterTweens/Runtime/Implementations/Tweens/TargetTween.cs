using System;
using Better.Conditions.Runtime;
using Better.Tweens.Runtime.Actions;
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

        protected override void OnInitialized()
        {
            RemoveTargetDependency();
            AddTargetDependency();

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
            RemoveTargetDependency();
        }

        protected virtual void OnTargetChanged()
        {
            AddTargetDependency();
        }

        private void AddTargetDependency()
        {
            AddTag(Target);

            if (Target is Object unityTarget)
            {
                var destroyObjectCondition = new NullReferenceObjectCondition(unityTarget, true);
                this.AddTrigger<StopAction>(destroyObjectCondition, TargetTriggerId);
            }
        }

        private void RemoveTargetDependency()
        {
            RemoveTag(Target);
            RemoveTriggers(TargetTriggerId);
        }

        public override bool IsRunnable()
        {
            return base.IsRunnable() && Target != null;
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