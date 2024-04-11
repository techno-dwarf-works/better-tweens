using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SineEase : InOutEase
    {
        public SineEase(EaseMode mode) : base(mode)
        {
        }

        public SineEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return -Mathf.Cos(time * Mathf.PI / 2f);
        }

        public override Ease Clone()
        {
            return new SineEase(Mode);
        }
    }
}