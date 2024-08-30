using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class QuadEase : InOutEase
    {
        public QuadEase(EaseMode mode) : base(mode)
        {
        }

        public QuadEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return time * time;
        }

        public override Ease Clone()
        {
            return new QuadEase(Mode);
        }
    }
}