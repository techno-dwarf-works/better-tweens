using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StartColorLineRendererTween : ColorTween<LineRenderer>
    {
        protected override Color GetCurrentValue()
        {
            return Target.startColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.startColor = value;
        }
    }
}