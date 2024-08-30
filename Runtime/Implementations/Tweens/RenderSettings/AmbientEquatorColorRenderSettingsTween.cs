using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AmbientEquatorColorRenderSettingsTween : ColorTween
    {
        protected override Color GetCurrentValue()
        {
            return RenderSettings.ambientEquatorColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            RenderSettings.ambientEquatorColor = value;
        }
    }
}