using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SubtractiveShadowColorRenderSettingsTween : ColorTween
    {
        protected override Color GetCurrentValue()
        {
            return RenderSettings.subtractiveShadowColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            RenderSettings.subtractiveShadowColor = value;
        }
    }
}