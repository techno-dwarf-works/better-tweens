using System;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class LoopCount
    {
        public const int MinValue = 1;

        [SerializeField] private bool _infinity;

        [Min(MinValue)]
        [SerializeField] private int _value;

        public bool Infinity => _infinity;
        public int Value => _value;

        public LoopCount(bool infinity, int value)
        {
            _infinity = infinity;
            _value = Math.Max(MinValue, value);
        }

        public LoopCount() : this(false, MinValue)
        {
        }

        public void SetValue(int value)
        {
            _infinity = false;
            _value = Mathf.Max(MinValue, value);
        }

        public void MakeInfinity()
        {
            _infinity = true;
            _value = MinValue;
        }
    }
}