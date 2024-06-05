using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class MassRigidbody2DTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.mass;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.mass = value;
        }
    }
}