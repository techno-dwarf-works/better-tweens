using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BrightnessLensFlareTween : FloatTween<LensFlare>
    {
        protected override float GetCurrentValue()
        {
            return Target.brightness;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.brightness = value;
        }
    }
}