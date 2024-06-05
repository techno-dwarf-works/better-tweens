using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class InertiaTensorRotationRigidbody2DTween : QuaternionTween<Rigidbody>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

        protected override Quaternion GetCurrentValue()
        {
            return Target.inertiaTensorRotation;
        }

        protected override void SetCurrentValue(Quaternion value)
        {
            Target.inertiaTensorRotation = value;
        }
    }
}