using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WidthMultiplierLineRendererTween : FloatTween<LineRenderer>
    {
        protected override float GetCurrentValue()
        {
            return Target.widthMultiplier;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.widthMultiplier = value;
        }
    }
}