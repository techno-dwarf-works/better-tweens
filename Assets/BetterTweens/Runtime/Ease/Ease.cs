using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Ease
    {
        // TODO: Test and update formuls
        
        public abstract float Evaluate(float time);
        public abstract Ease Clone();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}