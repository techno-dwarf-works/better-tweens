using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UseFrustumShadowCasterLightTween : BoolTween<Light>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useViewFrustumForShadowCasterCull;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.useViewFrustumForShadowCasterCull == value)
            {
                return;
            }

            Target.useViewFrustumForShadowCasterCull = value;
        }
    }
}