using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NumCapVerticesLineRendererTween : IntTween<LineRenderer>
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