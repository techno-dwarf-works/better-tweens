using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FogEndDistanceRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.fogEndDistance;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.fogEndDistance = value;
        }
    }
}