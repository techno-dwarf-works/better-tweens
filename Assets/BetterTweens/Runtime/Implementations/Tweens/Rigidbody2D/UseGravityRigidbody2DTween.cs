﻿using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class UseGravityRigidbody2DTween : BoolTween<Rigidbody>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useGravity;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.useGravity = value;
        }
    }
}