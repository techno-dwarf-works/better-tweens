using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class InnerSpotAngleLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.innerSpotAngle;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.innerSpotAngle = value;
        }
    }
}