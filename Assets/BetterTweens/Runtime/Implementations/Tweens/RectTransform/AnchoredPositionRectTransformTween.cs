using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AnchoredPositionRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.anchoredPosition;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.anchoredPosition = value;
        }
    }
}