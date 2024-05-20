using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class LoopCount : InfinitableData<int>
    {
        public const int MinValue = 1;
        public const int MaxValue = 1000000000;

        // TODO: Attributes
        [SerializeField] private int _value;

        public override int Value
        {
            get => _value;
            protected set => _value = value;
        }

        public LoopCount()
        {
            _value = MinValue;
        }

        private LoopCount(int value, bool infinity) : base(infinity)
        {
            _value = value;
        }

        protected override void OnValueChanged()
        {
            base.OnValueChanged();
            
            if (Value > MaxValue)
            {
                var message = $"{nameof(Value)}({Value}) more than the {nameof(MaxValue)}({MaxValue}), will become infinite";
                LogUtility.LogWarning(message);

                MakeInfinity();
                return;
            }

            Value = Math.Max(MinValue, Value);
        }

        protected override void OnBecameInfinity()
        {
            Value = MinValue;
        }

        public LoopCount Clone()
        {
            return new LoopCount(Value, Infinity);
        }
    }
}