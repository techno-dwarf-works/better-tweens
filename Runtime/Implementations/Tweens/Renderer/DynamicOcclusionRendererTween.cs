using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DynamicOcclusionRendererTween : BoolTween<Renderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.allowOcclusionWhenDynamic;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.allowOcclusionWhenDynamic == value)
            {
                return;
            }

            Target.allowOcclusionWhenDynamic = value;
        }
    }
}