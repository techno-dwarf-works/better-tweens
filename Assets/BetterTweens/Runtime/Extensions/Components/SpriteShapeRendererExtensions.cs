using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;
using UnityEngine.U2D;

namespace Better.Tweens.Runtime
{
    public static class SpriteShapeRendererExtensions
    {
        public static ColorSpriteShapeRendererTween TweenColor(this SpriteShapeRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorSpriteShapeRendererTween, SpriteShapeRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<ColorSpriteShapeRendererTween> TweensColor(this IEnumerable<SpriteShapeRenderer> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorSpriteShapeRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorSpriteShapeRendererTween TweenColor(this SpriteShapeRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorSpriteShapeRendererTween, SpriteShapeRenderer>(options, optionsMode);
        }

        public static IEnumerable<ColorSpriteShapeRendererTween> TweensColor(this IEnumerable<SpriteShapeRenderer> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorSpriteShapeRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}