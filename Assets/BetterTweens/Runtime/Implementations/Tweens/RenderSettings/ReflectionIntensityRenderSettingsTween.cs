using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionIntensityRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.reflectionIntensity;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.reflectionIntensity = value;
        }
    }
}