using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowBiasLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowBias;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowBias = value;
        }
    }
}