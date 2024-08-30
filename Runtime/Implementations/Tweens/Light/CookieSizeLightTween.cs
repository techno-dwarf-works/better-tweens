using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CookieSizeLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.cookieSize;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.cookieSize = value;
        }
    }
}