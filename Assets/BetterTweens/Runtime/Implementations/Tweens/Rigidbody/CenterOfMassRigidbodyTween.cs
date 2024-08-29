using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CenterOfMassRigidbodyTween : Vector3Tween<Rigidbody>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.centerOfMass;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.centerOfMass = value;
        }
    }
}