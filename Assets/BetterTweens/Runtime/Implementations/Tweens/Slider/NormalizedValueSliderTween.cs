using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NormalizedValueSliderTween : FloatTween<Slider>
    {
        protected override float GetCurrentValue()
        {
            return Target.normalizedValue;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.normalizedValue = value;
        }
    }
}