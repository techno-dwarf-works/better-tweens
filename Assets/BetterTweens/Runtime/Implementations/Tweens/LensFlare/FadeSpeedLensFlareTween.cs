using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FadeSpeedLensFlareTween : FloatTween<LensFlare>
    {
        protected override float GetCurrentValue()
        {
            return Target.fadeSpeed;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.fadeSpeed = value;
        }
    }
}