using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowNormalBiasLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowNormalBias;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowNormalBias = value;
        }
    }
}