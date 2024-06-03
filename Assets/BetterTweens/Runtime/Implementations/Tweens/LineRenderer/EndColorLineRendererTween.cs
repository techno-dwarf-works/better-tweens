using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EndColorLineRendererTween : ColorTween<LineRenderer>
    {
        protected override Color GetCurrentValue()
        {
            return Target.endColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.endColor = value;
        }
    }
}