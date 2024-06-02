using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowNearPlaneLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowNearPlane;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowNearPlane = value;
        }
    }
}