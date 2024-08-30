using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReceiveShadowsRendererTween : BoolTween<Renderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.receiveShadows;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.receiveShadows == value)
            {
                return;
            }

            Target.receiveShadows = value;
        }
    }
}