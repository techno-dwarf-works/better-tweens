using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WorldSpaceLineRendererTween : BoolTween<LineRenderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useWorldSpace;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.useWorldSpace == value)
            {
                return;
            }

            Target.useWorldSpace = value;
        }
    }
}