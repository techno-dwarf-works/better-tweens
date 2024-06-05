using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class RotationRigidbodyTween : QuaternionTween<Rigidbody>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

        protected override Quaternion GetCurrentValue()
        {
            return Target.rotation;
        }

        protected override void SetCurrentValue(Quaternion value)
        {
            Target.MoveRotation(value);
        }
    }
}