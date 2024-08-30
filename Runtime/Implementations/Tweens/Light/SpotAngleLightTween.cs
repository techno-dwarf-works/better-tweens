using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SpotAngleLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.spotAngle;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.spotAngle = value;
        }
    }
}