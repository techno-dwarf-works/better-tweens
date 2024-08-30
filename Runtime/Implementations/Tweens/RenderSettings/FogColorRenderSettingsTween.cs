using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FogColorRenderSettingsTween : ColorTween
    {
        protected override Color GetCurrentValue()
        {
            return RenderSettings.fogColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            RenderSettings.fogColor = value;
        }
    }
}