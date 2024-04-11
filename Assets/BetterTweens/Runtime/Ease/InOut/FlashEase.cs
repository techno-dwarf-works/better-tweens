using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FlashEase : InOutEase
    {
        public FlashEase(EaseMode mode) : base(mode)
        {
        }

        public FlashEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return 1f - Mathf.Cos(Mathf.PI / 2f * Mathf.Pow(time, 3f));
        }

        public override Ease Clone()
        {
            return new FlashEase(Mode);
        }
    }
}