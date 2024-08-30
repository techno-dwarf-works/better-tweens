using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LensFlareExtensions
    {
        public static BrightnessLensFlareTween TweenBrightness(this LensFlare self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BrightnessLensFlareTween, LensFlare, float>(duration, options, optionsMode);
        }

        public static IEnumerable<BrightnessLensFlareTween> TweensBrightness(this IEnumerable<LensFlare> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BrightnessLensFlareTween>();
            }

            var tweens = new List<BrightnessLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBrightness(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLensFlareTween TweenColor(this LensFlare self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorLensFlareTween, LensFlare, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorLensFlareTween> TweensColor(this IEnumerable<LensFlare> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorLensFlareTween>();
            }

            var tweens = new List<ColorLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLensFlareTween TweenColor(this LensFlare self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorLensFlareTween, LensFlare>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorLensFlareTween> TweensColor(this IEnumerable<LensFlare> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorLensFlareTween>();
            }

            var tweens = new List<ColorLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FadeSpeedLensFlareTween TweenFadeSpeed(this LensFlare self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeSpeedLensFlareTween, LensFlare, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FadeSpeedLensFlareTween> TweensFadeSpeed(this IEnumerable<LensFlare> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FadeSpeedLensFlareTween>();
            }

            var tweens = new List<FadeSpeedLensFlareTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFadeSpeed(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}