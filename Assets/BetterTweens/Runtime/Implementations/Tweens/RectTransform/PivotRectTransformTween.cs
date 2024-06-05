﻿using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class PivotRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.pivot;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.pivot = value;
        }
    }
}