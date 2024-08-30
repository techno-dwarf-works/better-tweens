using System;
using Better.Attributes.Runtime.Select;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SimpleOverridable<TValue> : OverridableData<TValue>
    {
        [SerializeField] private TValue _overridenValue;

        protected override TValue OverridenValue
        {
            get => _overridenValue;
            set => _overridenValue = value;
        }

        public SimpleOverridable(TValue overridenValue)
        {
            _overridenValue = overridenValue;
        }
    }
}