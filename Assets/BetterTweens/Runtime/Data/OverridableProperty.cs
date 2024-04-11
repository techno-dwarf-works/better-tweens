using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class OverridableProperty<TValue>
    {
        [SerializeField] private bool _overriden;
        [SerializeField] private TValue _overridenValue;

        private TValue _sourceValue;

        public TValue Value => Overriden ? _overridenValue : _sourceValue;

        public bool Overriden
        {
            get => _overriden;
            set => _overriden = value;
        }

        public void SetSource(TValue value)
        {
            _sourceValue = value;
        }

        public void Override(TValue value)
        {
            Overriden = true;
            _overridenValue = value;
        }
    }
}