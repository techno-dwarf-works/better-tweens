using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class SizeDeltaRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.sizeDelta;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.sizeDelta = value;
        }
    }
}