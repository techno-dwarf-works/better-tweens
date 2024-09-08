using System;
using Better.Attributes.Runtime.Select;
using Better.Commons.Runtime.Interfaces;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class ImplementationOverridable<TValue> : OverridableData<TValue>, ICloneable<ImplementationOverridable<TValue>>
        where TValue : ICloneable<TValue>
    {
        [Select]
        [SerializeReference] private TValue _overridenValue;

        protected override TValue OverridenValue
        {
            get => _overridenValue;
            set => _overridenValue = value;
        }

        public ImplementationOverridable(TValue sourceValue, TValue overridenValue, bool overriden) : base(sourceValue, overriden)
        {
            _overridenValue = overridenValue;
        }

        public ImplementationOverridable(TValue overridenValue) : this(default, overridenValue, false)
        {
        }

        public ImplementationOverridable<TValue> Clone()
        {
            var overridenClone = _overridenValue == null ? default : _overridenValue.Clone();
            return new ImplementationOverridable<TValue>(overridenClone, SourceValue, Overriden);
        }
    }
}