using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UseAlphaShadowTween : BoolTween<Shadow>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useGraphicAlpha;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.useGraphicAlpha == value)
            {
                return;
            }

            Target.useGraphicAlpha = value;
        }
    }
}