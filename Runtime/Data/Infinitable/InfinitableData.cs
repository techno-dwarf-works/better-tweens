using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public abstract class InfinitableData<TValue>
    {
        [SerializeField] private bool _infinity;

        public bool Infinity => _infinity;
        public abstract TValue Value { get; protected set; }

        protected InfinitableData(bool infinity)
        {
            _infinity = infinity;
        }

        protected InfinitableData() : this(false)
        {
        }

        public void SetValue(TValue value)
        {
            Value = value;
            OnValueChanged();
        }

        protected virtual void OnValueChanged()
        {
            _infinity = false;
        }

        public void MakeInfinity()
        {
            _infinity = true;
            OnBecameInfinity();
        }

        protected abstract void OnBecameInfinity();
    }
}