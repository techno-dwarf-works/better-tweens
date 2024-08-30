using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UpTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.up;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.up = value;
        }
    }
}