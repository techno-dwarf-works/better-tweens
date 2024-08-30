using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ColorTemperatureLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.colorTemperature;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.colorTemperature = value;
        }
    }
}