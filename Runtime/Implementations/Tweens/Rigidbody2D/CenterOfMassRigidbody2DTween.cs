using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CenterOfMassRigidbody2DTween : Vector2Tween<Rigidbody2D>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.centerOfMass;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.centerOfMass = value;
        }
    }
}