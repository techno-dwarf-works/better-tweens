using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FogStartDistanceRenderSettingsTween : FloatTween
    {
        protected override float GetCurrentValue()
        {
            return RenderSettings.fogStartDistance;
        }

        protected override void SetCurrentValue(float value)
        {
            RenderSettings.fogStartDistance = value;
        }
    }
}