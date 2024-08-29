using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class VelocityRigidbodyTween : Vector3Tween<Rigidbody>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

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