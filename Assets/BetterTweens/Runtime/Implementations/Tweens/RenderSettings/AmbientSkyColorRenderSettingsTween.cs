using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AmbientSkyColorRenderSettingsTween : ColorTween
    {
        protected override Color GetCurrentValue()
        {
            return RenderSettings.ambientSkyColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            RenderSettings.ambientSkyColor = value;
        }
    }
}