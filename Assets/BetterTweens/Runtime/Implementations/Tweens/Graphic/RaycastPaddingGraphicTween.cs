using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class RaycastPaddingGraphicTween : Vector4Tween<Graphic>
    {
        protected override Vector4 GetCurrentValue()
        {
            return Target.raycastPadding;
        }

        protected override void SetCurrentValue(Vector4 value)
        {
            Target.raycastPadding = value;
        }
    }
}