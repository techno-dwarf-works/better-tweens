using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LensShiftCameraTween : Vector2Tween<Camera>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.lensShift;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.lensShift = value;
        }
    }
}