using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UseBoundingSphereLightTween : BoolTween<Light>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useBoundingSphereOverride;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.useBoundingSphereOverride == value)
            {
                return;
            }

            Target.useBoundingSphereOverride = value;
        }
    }
}