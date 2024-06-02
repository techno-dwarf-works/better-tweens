using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BoundingSphereLightTween : Vector4Tween<Light>
    {
        protected override Vector4 GetCurrentValue()
        {
            return Target.boundingSphereOverride;
        }

        protected override void SetCurrentValue(Vector4 value)
        {
            Target.boundingSphereOverride = value;
        }
    }
}