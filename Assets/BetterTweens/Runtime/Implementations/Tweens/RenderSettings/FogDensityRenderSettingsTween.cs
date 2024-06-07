using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FogDensityRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.fogDensity;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.fogDensity = value;
        }
    }
}