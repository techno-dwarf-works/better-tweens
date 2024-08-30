using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class HaloStrengthRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.haloStrength;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.haloStrength = value;
        }
    }
}