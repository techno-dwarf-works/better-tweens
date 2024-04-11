using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CircEase : InOutEase
    {
        public CircEase(EaseMode mode) : base(mode)
        {
        }

        public CircEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return 1f - Mathf.Sqrt(1f - time * time);
        }

        public override Ease Clone()
        {
            return new CircEase(Mode);
        }
    }
}