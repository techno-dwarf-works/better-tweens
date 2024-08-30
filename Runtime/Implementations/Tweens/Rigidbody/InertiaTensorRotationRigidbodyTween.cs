using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class InertiaTensorRotationRigidbodyTween : QuaternionTween<Rigidbody>
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