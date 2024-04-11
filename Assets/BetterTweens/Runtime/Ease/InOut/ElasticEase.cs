using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ElasticEase : InOutEase
    {
        private const float DefaultAmplitude = 1f;
        private const float DefaultFrequency = 0.3f;

        [SerializeField] private float _amplitude;
        [SerializeField] private float _frequency;

        public float Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }

        public float Amplitude
        {
            get => _amplitude;
            set => _amplitude = value;
        }

        public ElasticEase(float amplitude, float frequency, EaseMode mode = EaseMode.InOut) : base(mode)
        {
            _amplitude = amplitude;
            _frequency = frequency;
        }

        public ElasticEase(EaseMode mode) : this(DefaultAmplitude, DefaultFrequency, mode)
        {
        }

        public ElasticEase() : this(EaseMode.InOut)
        {
        }

        protected override float EvaluateIn(float time)
        {
            return -Amplitude * Mathf.Pow(2f, 10f * (time - 1)) * Mathf.Sin((time - 1f - Frequency / (2f * Mathf.PI)) * (2f * Mathf.PI) / Frequency);
        }

        public override Ease Clone()
        {
            return new ElasticEase(Amplitude, Frequency, Mode);
        }
    }
}