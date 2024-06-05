using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AnchoredPosition3DRectTransformTween : Vector3Tween<RectTransform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.anchoredPosition3D;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.anchoredPosition3D = value;
        }
    }
}