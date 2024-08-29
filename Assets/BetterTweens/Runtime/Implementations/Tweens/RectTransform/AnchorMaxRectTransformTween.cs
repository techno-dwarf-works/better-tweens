using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AnchorMaxRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.anchorMax;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.anchorMax = value;
        }
    }
}