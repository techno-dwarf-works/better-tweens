using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EffectColorShadowTween : ColorTween<Shadow>
    {
        protected override Color GetCurrentValue()
        {
            return Target.effectColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.effectColor = value;
        }
    }
}