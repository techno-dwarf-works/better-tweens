using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FlareFadeSpeedRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.flareFadeSpeed;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.flareFadeSpeed = value;
        }
    }
}