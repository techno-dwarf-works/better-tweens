using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PositionCountLineRendererTween : IntTween<LineRenderer>
    {
        protected override int GetCurrentValue()
        {
            return Target.positionCount;
        }

        protected override void SetCurrentValue(int value)
        {
            if (Target.positionCount == value)
            {
                return;
            }

            Target.positionCount = value;
        }
    }
}