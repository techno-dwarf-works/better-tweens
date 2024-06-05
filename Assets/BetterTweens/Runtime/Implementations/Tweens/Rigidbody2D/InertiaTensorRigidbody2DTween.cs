using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class InertiaTensorRigidbody2DTween : Vector3Tween<Rigidbody>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.inertiaTensor;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.inertiaTensor = value;
        }
    }
}