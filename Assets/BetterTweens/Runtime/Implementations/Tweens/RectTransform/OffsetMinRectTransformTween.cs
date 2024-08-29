using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class OffsetMinRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.offsetMin;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.offsetMin = value;
        }
    }
}