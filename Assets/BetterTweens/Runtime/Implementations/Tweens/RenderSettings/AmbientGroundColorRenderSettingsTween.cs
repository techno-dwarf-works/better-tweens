using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AmbientGroundColorRenderSettingsTween : ColorTween
    {
        protected override Color GetCurrentValue()
        {
            return RenderSettings.ambientGroundColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            RenderSettings.ambientGroundColor = value;
        }
    }
}