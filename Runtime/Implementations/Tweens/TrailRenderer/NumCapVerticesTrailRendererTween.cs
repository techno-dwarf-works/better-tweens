using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NumCapVerticesTrailRendererTween : IntTween<TrailRenderer>
    {
        protected override int GetCurrentValue()
        {
            return Target.numCapVertices;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.numCapVertices = value;
        }
    }
}