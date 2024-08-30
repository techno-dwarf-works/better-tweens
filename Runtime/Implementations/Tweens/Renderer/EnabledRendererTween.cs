using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EnabledRendererTween : BoolTween<Renderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.enabled;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.enabled == value)
            {
                return;
            }

            Target.enabled = value;
        }
    }
}