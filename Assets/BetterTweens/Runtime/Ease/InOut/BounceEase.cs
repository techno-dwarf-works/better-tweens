using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BounceEase : InOutEase
    {
        public BounceEase(EaseMode mode) : base(mode)
        {
        }

        public BounceEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            const float baseTime = 1f;
            const float div = 2.75f;
            const float mult = 7.5625f;

            if (time < baseTime / div)
            {
                return baseTime - (baseTime - time) * (baseTime - time) * mult;
            }

            if (time < 2f / div)
            {
                time -= 1.5f / div;
                return baseTime - (baseTime - time) * (baseTime - time) * mult + 0.75f;
            }

            if (time < 2.5f / div)
            {
                time -= 2.25f / div;
                return baseTime - (baseTime - time) * (baseTime - time) * mult + 0.9375f;
            }

            time -= 2.625f / div;
            return baseTime - (baseTime - time) * (baseTime - time) * mult + 0.984375f;
        }

        public override Ease Clone()
        {
            return new BounceEase(Mode);
        }
    }
}