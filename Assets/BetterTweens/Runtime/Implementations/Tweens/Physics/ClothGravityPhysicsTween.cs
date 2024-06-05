﻿using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class ClothGravityPhysicsTween : Vector3Tween
    {
        protected override Vector3 GetCurrentValue()
        {
            return Physics.clothGravity;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Physics.clothGravity = value;
        }
    }
}