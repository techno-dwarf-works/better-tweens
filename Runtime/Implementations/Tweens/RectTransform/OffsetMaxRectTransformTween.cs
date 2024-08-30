using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class OffsetMaxRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.offsetMax;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.offsetMax = value;
        }
    }
}