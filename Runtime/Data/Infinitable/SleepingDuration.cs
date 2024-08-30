using System;
using Better.Commons.Runtime.Interfaces;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SleepingDuration : InfinitableData<float>, ICloneable<SleepingDuration>
    {
        public const float MinValue = 0f;
        public const float DefaultValue = 15f;

        [Min(MinValue)]
        [SerializeField] private float _value;

        public override float Value
        {
            get => _value;
            protected set => _value = value;
        }

        public SleepingDuration()
        {
            _value = DefaultValue;
        }

        private SleepingDuration(float value, bool infinity) : base(infinity)
        {
            _value = value;
        }

        protected override void OnValueChanged()
        {
            base.OnValueChanged();
            
            Value = Math.Max(MinValue, Value);
        }

        protected override void OnBecameInfinity()
        {
            Value = MinValue;
        }

        public SleepingDuration Clone()
        {
            return new SleepingDuration(Value, Infinity);
        }
    }
}