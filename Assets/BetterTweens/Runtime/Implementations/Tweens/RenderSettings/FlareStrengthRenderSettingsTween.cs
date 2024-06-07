using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FlareStrengthRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.flareStrength;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.flareStrength = value;
        }
    }
}