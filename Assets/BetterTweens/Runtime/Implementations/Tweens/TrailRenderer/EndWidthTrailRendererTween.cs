using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EndWidthTrailRendererTween : FloatTween<TrailRenderer>
    {
        protected override float GetCurrentValue()
        {
            return Target.endWidth;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.endWidth = value;
        }
    }
}