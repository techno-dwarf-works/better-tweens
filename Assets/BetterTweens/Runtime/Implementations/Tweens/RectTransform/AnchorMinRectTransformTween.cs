using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AnchorMinRectTransformTween : Vector2Tween<RectTransform>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.anchorMin;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.anchorMin = value;
        }
    }
}