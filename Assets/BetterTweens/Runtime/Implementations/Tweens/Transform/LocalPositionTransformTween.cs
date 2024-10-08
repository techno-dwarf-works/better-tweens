﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LocalPositionTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.localPosition;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.localPosition = value;
        }
    }
}