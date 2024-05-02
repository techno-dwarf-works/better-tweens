using System;
using Better.Attributes.Runtime.Select;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SelectOverridableProperty<TValue> : OverridableProperty<TValue>
    {
        [Select]
        [SerializeReference] private TValue _overridenValue;
        
        protected override TValue OverridenValue
        {
            get => _overridenValue;
            set => _overridenValue = value;
        }
    }
}