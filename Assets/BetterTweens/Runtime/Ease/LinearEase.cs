using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LinearEase : Ease
    {
        public override float Evaluate(float time)
        {
            return time;
        }

        public override Ease Clone()
        {
            return this;
        }
    }
}