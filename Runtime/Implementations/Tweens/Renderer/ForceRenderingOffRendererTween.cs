using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ForceRenderingOffRendererTween : BoolTween<Renderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.forceRenderingOff;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.forceRenderingOff == value)
            {
                return;
            }

            Target.forceRenderingOff = value;
        }
    }
}