using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FadeGraphicTween : FloatTween<Graphic>
    {
        protected override float GetCurrentValue()
        {
            return Target.color.a;
        }

        protected override void SetCurrentValue(float value)
        {
            var color = Target.color;
            color.a = value;
            Target.color = color;
        }
    }
}