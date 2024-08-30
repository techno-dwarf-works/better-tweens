using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionBouncesRenderSettingsTween : IntTween
    {
        protected override int GetCurrentValue()
        {
            return RenderSettings.reflectionBounces;
        }

        protected override void SetCurrentValue(int value)
        {
            RenderSettings.reflectionBounces = value;
        }
    }
}