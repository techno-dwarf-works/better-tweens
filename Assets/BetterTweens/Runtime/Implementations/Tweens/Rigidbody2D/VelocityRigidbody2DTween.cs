using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VelocityRigidbody2DTween : Vector3Tween<Rigidbody>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.velocity;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.velocity = value;
        }
    }
}