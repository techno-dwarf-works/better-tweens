using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NumCornerVerticesLineRendererTween : IntTween<LineRenderer>
    {
        protected override int GetCurrentValue()
        {
            return Target.numCornerVertices;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.numCornerVertices = value;
        }
    }
}