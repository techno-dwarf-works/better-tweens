using System;
using Better.Commons.Runtime.Interfaces;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class ValueOverridable<TValue> : OverridableData<TValue>, ICloneable<ValueOverridable<TValue>>
        where TValue : struct
    {
        [SerializeField] private TValue _overridenValue;

        protected override TValue OverridenValue
        {
            get => _overridenValue;
            set => _overridenValue = value;
        }

        public ValueOverridable(TValue overridenValue)
        {
            _overridenValue = overridenValue;
        }

        public ValueOverridable<TValue> Clone()
        {
            return new ValueOverridable<TValue>(OverridenValue);
        }
    }
}