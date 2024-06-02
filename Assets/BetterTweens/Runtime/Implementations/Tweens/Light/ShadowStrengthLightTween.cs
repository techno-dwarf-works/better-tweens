using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowStrengthLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowStrength;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowStrength = value;
        }
    }
}