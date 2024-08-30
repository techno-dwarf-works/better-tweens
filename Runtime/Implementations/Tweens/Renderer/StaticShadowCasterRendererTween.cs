using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StaticShadowCasterRendererTween : BoolTween<Renderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.staticShadowCaster;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.staticShadowCaster == value)
            {
                return;
            }

            Target.staticShadowCaster = value;
        }
    }
}