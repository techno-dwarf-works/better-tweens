using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BackEase : InOutEase
    {
        private const float DefaultOvershoot = 1.70158f;

        [SerializeField] private float _overshoot;

        public float Overshoot
        {
            get => _overshoot;
            set => _overshoot = value;
        }

        public BackEase(float overshoot, EaseMode mode = EaseMode.InOut) : base(mode)
        {
            _overshoot = overshoot;
        }

        public BackEase() : this(DefaultOvershoot)
        {
        }

        protected override float EvaluateIn(float time)
        {
            return time * time * ((Overshoot + 1) * time - Overshoot);
        }

        public override Ease Clone()
        {
            return new BackEase(_overshoot, Mode);
        }
    }
}