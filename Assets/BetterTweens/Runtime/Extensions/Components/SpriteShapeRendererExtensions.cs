using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using UnityEngine.U2D;

namespace Better.Tweens.Runtime
{
    public static class SpriteShapeRendererExtensions
    {
        public static ColorSpriteShapeRendererTween TweenColor(this SpriteShapeRenderer self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorSpriteShapeRendererTween, SpriteShapeRenderer, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorSpriteShapeRendererTween> TweensColor(this IEnumerable<SpriteShapeRenderer> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorSpriteShapeRendererTween>();
            }

            var tweens = new List<ColorSpriteShapeRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorSpriteShapeRendererTween TweenColor(this SpriteShapeRenderer self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorSpriteShapeRendererTween, SpriteShapeRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorSpriteShapeRendererTween> TweensColor(this IEnumerable<SpriteShapeRenderer> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorSpriteShapeRendererTween>();
            }

            var tweens = new List<ColorSpriteShapeRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}