using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class IntensityLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.intensity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.intensity = value;
        }
    }
}