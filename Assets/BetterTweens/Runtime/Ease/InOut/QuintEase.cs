using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class QuintEase : InOutEase
    {
        public QuintEase(EaseMode mode) : base(mode)
        {
        }

        public QuintEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return time * time * time * time * time;
        }

        public override Ease Clone()
        {
            return new QuintEase(Mode);
        }
    }
}