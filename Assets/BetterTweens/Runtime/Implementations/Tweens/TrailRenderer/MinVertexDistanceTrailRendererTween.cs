using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MinVertexDistanceTrailRendererTween : FloatTween<TrailRenderer>
    {
        protected override float GetCurrentValue()
        {
            return Target.minVertexDistance;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.minVertexDistance = value;
        }
    }
}