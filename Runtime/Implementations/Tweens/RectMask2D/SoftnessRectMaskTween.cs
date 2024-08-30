using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SoftnessRectMaskTween : Vector2IntTween<RectMask2D>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.softness;
        }

        protected override void SetCurrentValue(Vector2Int value)
        {
            Target.softness = value;
        }
    }
}