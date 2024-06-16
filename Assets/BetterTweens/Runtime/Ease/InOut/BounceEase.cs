using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BounceEase : InOutEase
    {
        public const int MinBounces = 1;
        public const int DefaultBounces = 3;
        public const float MinBounciness = 0f;
        public const float MaxBounciness = 1f;
        public const float DefaultBounciness = 0.5f;

        [Min(MinBounces)]
        [SerializeField] private int _bounces;

        [Range(MinBounciness, MaxBounciness)]
        [SerializeField] private float _bounciness;

        public int Bounces
        {
            get => _bounces;
            set => _bounces = Mathf.Max(MinBounces, value);
        }

        public float Bounciness
        {
            get => _bounciness;
            set => _bounciness = Mathf.Clamp(value, MinBounciness, MaxBounciness);
        }

        public BounceEase(int bounces, float bounciness, EaseMode mode) : base(mode)
        {
            Bounces = bounces;
            Bounciness = bounciness;
        }

        public BounceEase(EaseMode mode) : this(DefaultBounces, DefaultBounciness, mode)
        {
        }

        public BounceEase() : this(EaseMode.InOut)
        {
        }

        protected override float EvaluateIn(float time)
        {
            var invertedTime = 1f - time;
            var frequency = _bounces - 0.5f;
            var value = 1f * Mathf.Abs(Mathf.Sin(time * Mathf.PI * frequency)) * Mathf.Pow(1f, frequency * invertedTime);
            var normalizedValue = value / 1f;
            normalizedValue -= normalizedValue * _bounciness * invertedTime;

            return normalizedValue;
        }

        public override Ease Clone()
        {
            return new BounceEase(Bounces, Bounciness, Mode);
        }
    }
}