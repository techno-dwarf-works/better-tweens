using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PowerEase : InOutEase
    {
        public  const float MinPower = 0f;
        public  const float DefaultPower = 2f;

        [Min(MinPower)]
        [SerializeField] private float _power;

        public float Power
        {
            get => _power;
            set => _power = Mathf.Max(MinPower, value);
        }

        public PowerEase(float power, EaseMode mode) : base(mode)
        {
            Power = power;
        }

        public PowerEase(EaseMode mode) : this(DefaultPower, mode)
        {
        }

        public PowerEase() : this(DefaultPower, EaseMode.InOut)
        {
        }

        protected override float EvaluateIn(float time)
        {
            return Mathf.Pow(time, Power);
        }

        public override Ease Clone()
        {
            return new PowerEase(Power, Mode);
        }
    }
}