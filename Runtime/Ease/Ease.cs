using System;
using Better.Commons.Runtime.Interfaces;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Ease : ICloneable<Ease>
    {
        public abstract float Evaluate(float time);

        public abstract Ease Clone();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}