using System;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class LoopCount
    {
        public const int MinValue = 1;
        public const int MaxValue = 1000000000;

        [SerializeField] private bool _infinity;
        [SerializeField] private int _value;

        public bool Infinity => _infinity;
        public int Value => _value;

        public LoopCount()
        {
            _value = MinValue;
            _infinity = false;
        }

        public void SetValue(int value)
        {
            if (value > MaxValue)
            {
                var message = $"{nameof(value)}({value}) more than the {nameof(MaxValue)}({MaxValue}), will become infinite";
                LogUtility.LogWarning(message);

                MakeInfinity();
                return;
            }

            _infinity = false;
            _value = Math.Max(value, MinValue);
        }

        public void MakeInfinity()
        {
            _infinity = true;
            _value = MinValue;
        }
    }
}