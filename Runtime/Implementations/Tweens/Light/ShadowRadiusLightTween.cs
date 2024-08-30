using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowRadiusLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowRadius;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowRadius = value;
        }
    }
}