using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LensFlareExtensions
    {
        public static BrightnessLensFlareTween TweenBrightness(this LensFlare self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BrightnessLensFlareTween, LensFlare, float>(options, optionsMode);
        }

        public static ColorLensFlareTween TweenColor(this LensFlare self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorLensFlareTween, LensFlare, Color, ColorOptions>(options, optionsMode);
        }

        public static ColorLensFlareTween TweenColor(this LensFlare self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorLensFlareTween, LensFlare>(options, optionsMode);
        }

        public static FadeSpeedLensFlareTween TweenFadeSpeed(this LensFlare self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeSpeedLensFlareTween, LensFlare, float>(options, optionsMode);
        }
    }
}