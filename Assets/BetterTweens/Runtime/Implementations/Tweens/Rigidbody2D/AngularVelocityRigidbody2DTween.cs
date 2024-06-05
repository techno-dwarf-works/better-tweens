﻿using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AngularVelocityRigidbody2DTween : Vector3Tween<Rigidbody>
    {
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