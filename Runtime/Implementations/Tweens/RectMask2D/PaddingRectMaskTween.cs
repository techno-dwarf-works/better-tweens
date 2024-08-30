using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PaddingRectMaskTween : Vector4Tween<RectMask2D>
    {
        protected override Vector4 GetCurrentValue()
        {
            return Target.padding;
        }

        protected override void SetCurrentValue(Vector4 value)
        {
            Target.padding = value;
        }
    }
}