using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StartColorTrailRendererTween : ColorTween<TrailRenderer>
    {
        protected override Color GetCurrentValue()
        {
            return Target.startColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.startColor = value;
        }
    }
}