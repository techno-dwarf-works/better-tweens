using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EndColorTrailRendererTween : ColorTween<TrailRenderer>
    {
        protected override Color GetCurrentValue()
        {
            return Target.endColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.endColor = value;
        }
    }
}