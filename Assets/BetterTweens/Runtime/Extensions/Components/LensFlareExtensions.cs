using System.Collections.Generic;
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

        public static IEnumerable<BrightnessLensFlareTween> TweensBrightness(this IEnumerable<LensFlare> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BrightnessLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBrightness(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLensFlareTween TweenColor(this LensFlare self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorLensFlareTween, LensFlare, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<ColorLensFlareTween> TweensColor(this IEnumerable<LensFlare> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLensFlareTween TweenColor(this LensFlare self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorLensFlareTween, LensFlare>(options, optionsMode);
        }

        public static IEnumerable<ColorLensFlareTween> TweensColor(this IEnumerable<LensFlare> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FadeSpeedLensFlareTween TweenFadeSpeed(this LensFlare self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeSpeedLensFlareTween, LensFlare, float>(options, optionsMode);
        }

        public static IEnumerable<FadeSpeedLensFlareTween> TweensFadeSpeed(this IEnumerable<LensFlare> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FadeSpeedLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFadeSpeed(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}