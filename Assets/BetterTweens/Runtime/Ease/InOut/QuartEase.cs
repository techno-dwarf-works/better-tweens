using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class QuartEase : InOutEase
    {
        public QuartEase(EaseMode mode) : base(mode)
        {
        }

        public QuartEase()
        {
        }

        protected override float EvaluateIn(float time)
        {
            return time * time * time * time;
        }

        public override Ease Clone()
        {
            return new QuartEase(Mode);
        }
    }
}