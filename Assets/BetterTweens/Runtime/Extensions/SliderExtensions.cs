using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class SliderExtensions
    {
        public static NormalizedValueSliderTween TweenNormalizedValue(this Slider self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NormalizedValueSliderTween, Slider, float>(options, optionsMode);
        }
    }
}