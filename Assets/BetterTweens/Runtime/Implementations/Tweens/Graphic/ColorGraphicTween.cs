using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
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