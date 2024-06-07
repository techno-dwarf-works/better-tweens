using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AmbientIntensityRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.ambientIntensity;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.ambientIntensity = value;
        }
    }
}