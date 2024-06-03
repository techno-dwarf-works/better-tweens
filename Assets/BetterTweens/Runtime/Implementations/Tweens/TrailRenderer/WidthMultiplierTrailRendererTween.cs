using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WidthMultiplierTrailRendererTween : FloatTween<TrailRenderer>
    {
        protected override float GetCurrentValue()
        {
            return Target.widthMultiplier;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.widthMultiplier = value;
        }
    }
}