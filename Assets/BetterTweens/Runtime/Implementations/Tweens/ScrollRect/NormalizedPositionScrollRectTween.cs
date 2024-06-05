using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NormalizedPositionScrollRectTween : Vector2Tween<ScrollRect>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.normalizedPosition;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.normalizedPosition = value;
        }
    }
}