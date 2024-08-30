using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CubicEase : InOutEase
    {
        public CubicEase(EaseMode mode) : base(mode)
        {
        }

        public CubicEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return time * time * time;
        }

        public override Ease Clone()
        {
            return new CubicEase(Mode);
        }
    }
}