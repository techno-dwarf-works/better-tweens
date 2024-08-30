using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ElasticEase : InOutEase
    {
        public const float MinAmplitude = 1f;
        public const float DefaultAmplitude = 2f;
        public const float MinFrequency = 1f;
        public const float DefaultFrequency = 10f;

        [Min(MinAmplitude)]
        [SerializeField] private float _amplitude;

        [Min(MinFrequency)]
        [SerializeField] private float _frequency;

        public float Frequency
        {
            get => _frequency;
            set => _frequency = Mathf.Max(MinFrequency, value);
        }

        public float Amplitude
        {
            get => _amplitude;
            set => _amplitude = Mathf.Max(MinAmplitude, value);
        }

        public ElasticEase(float amplitude, float frequency, EaseMode mode = EaseMode.InOut) : base(mode)
        {
            Amplitude = amplitude;
            Frequency = frequency;
        }

        public ElasticEase(EaseMode mode) : this(DefaultAmplitude, DefaultFrequency, mode)
        {
        }

        public ElasticEase() : this(EaseMode.InOut)
        {
        }

        protected override float EvaluateIn(float time)
        {
            const float exp = 2f * Mathf.PI / 3f;

            if (time <= 0f)
            {
                return 0f;
            }

            if (time >= 1f)
            {
                return 1f;
            }

            return -Mathf.Pow(_amplitude, _frequency * time - _frequency) * Mathf.Sin((time * _frequency - 10.75f) * exp);
        }

        public override Ease Clone()
        {
            return new ElasticEase(Amplitude, Frequency, Mode);
        }
    }
}