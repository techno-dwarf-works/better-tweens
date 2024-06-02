using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ColorGraphicTween : ColorTween<Graphic>
    {
        protected override Color GetCurrentValue()
        {
            return Target.color;
        }

        protected override void SetCurrentValue(Color value)
        {
            Target.color = value;
        }
    }
}