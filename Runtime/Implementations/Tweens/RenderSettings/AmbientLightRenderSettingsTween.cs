using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AmbientLightRenderSettingsTween : ColorTween
    {
        protected override Color GetCurrentValue()
        {
            return RenderSettings.ambientLight;
        }

        protected override void SetCurrentValue(Color value)
        {
            RenderSettings.ambientLight = value;
        }
    }
}