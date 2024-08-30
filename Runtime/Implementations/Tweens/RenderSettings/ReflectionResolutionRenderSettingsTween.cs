using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionResolutionRenderSettingsTween : IntTween
    {
        protected override int GetCurrentValue()
        {
            return RenderSettings.defaultReflectionResolution;
        }

        protected override void SetCurrentValue(int value)
        {
            RenderSettings.defaultReflectionResolution = value;
        }
    }
}