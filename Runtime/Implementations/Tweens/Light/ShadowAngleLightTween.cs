using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowAngleLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowAngle;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowAngle = value;
        }
    }
}