﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LocalScaleTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.localScale;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.localScale = value;
        }
    }
}