using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ExpoEase : InOutEase
    {
        public ExpoEase(EaseMode mode) : base(mode)
        {
        }

        public ExpoEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            if (time == 0)
            {
                return 0;
            }

            return Mathf.Pow(2f, 10f * (time - 1f));
        }

        public override Ease Clone()
        {
            return new ExpoEase(Mode);
        }
    }
}