using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class MaxAngularVelocityRigidbody2DTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.maxAngularVelocity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.maxAngularVelocity = value;
        }
    }
}