using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowBiasLineRendererTween : FloatTween<LineRenderer>
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