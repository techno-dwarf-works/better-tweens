using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public abstract class OverridableData<TValue>
    {
        [SerializeField] private bool _overriden;
        
        public TValue Value => Overriden ? OverridenValue : SourceValue;
        protected abstract TValue OverridenValue { get; set; }
        protected TValue SourceValue { get; private set; }

        public bool Overriden
        {
            get => _overriden;
            set => _overriden = value;
        }

        protected OverridableData()
        {
        }

        protected OverridableData(TValue sourceValue, bool overriden)
        {
            SourceValue = sourceValue;
            _overriden = overriden;
        }

        public void SetSource(TValue value)
        {
            SourceValue = value;
        }

        public void Override(TValue value)
        {
            Overriden = true;
            OverridenValue = value;
        }
    }
}