using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Ease
    {
        public abstract float Evaluate(float time);
        public abstract Ease Clone();
    }
}