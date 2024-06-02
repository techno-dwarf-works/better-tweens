using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UseShadowMatrixLightTween : BoolTween<Light>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useShadowMatrixOverride;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.useShadowMatrixOverride == value)
            {
                return;
            }

            Target.useShadowMatrixOverride = value;
        }
    }
}