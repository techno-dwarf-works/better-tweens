using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AngularVelocityRigidbodyTween : Vector3Tween<Rigidbody>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

        protected override Vector3 GetCurrentValue()
        {
            return Target.angularVelocity;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.angularVelocity = value;
        }
    }
}