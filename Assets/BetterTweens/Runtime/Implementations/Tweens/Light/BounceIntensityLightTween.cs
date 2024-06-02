using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BounceIntensityLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.bounceIntensity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.bounceIntensity = value;
        }
    }
}