using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
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