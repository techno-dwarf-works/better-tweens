﻿using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class VelocityRigidbody2DTween : Vector2Tween<Rigidbody2D>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.velocity;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.velocity = value;
        }
    }
}