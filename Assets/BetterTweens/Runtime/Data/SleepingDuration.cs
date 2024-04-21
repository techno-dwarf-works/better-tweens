using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SleepingDuration
    {
        public const float MinValue = 0f;

        [SerializeField] private bool _infinity;

        [Min(MinValue)]
        [SerializeField] private float _value;

        public bool Infinity => _infinity;
        public float Value => _value;

        public SleepingDuration(bool infinity, float value)
        {
            _infinity = infinity;
            _value = Mathf.Max(MinValue, value);
        }

        public SleepingDuration() : this(false, MinValue)
        {
        }

        public void SetValue(float value)
        {
            _infinity = false;
            _value = Mathf.Max(MinValue, value);
        }

        public void MakeInfinity()
        {
            _infinity = true;
            _value = MinValue;
        }

        public SleepingDuration Clone()
        {
            return new(_infinity, _value);
        }
    }
}