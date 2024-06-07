using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FogRenderSettingsTween : BoolTween
    {
        protected override bool GetCurrentValue()
        {
            return RenderSettings.fog;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (RenderSettings.fog == value)
            {
                return;
            }

            RenderSettings.fog = value;
        }
    }
}