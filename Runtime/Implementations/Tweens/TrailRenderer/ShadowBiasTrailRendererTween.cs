using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowBiasTrailRendererTween : FloatTween<TrailRenderer>
    {
        protected override float GetCurrentValue()
        {
            return Target.shadowBias;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.shadowBias = value;
        }
    }
}