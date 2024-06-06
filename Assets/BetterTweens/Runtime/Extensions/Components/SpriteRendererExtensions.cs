using System.Collections.Generic;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class SpriteRendererExtensions
    {
        public static ColorSpriteRendererTween TweenColor(this SpriteRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorSpriteRendererTween, SpriteRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<ColorSpriteRendererTween> TweensColor(this IEnumerable<SpriteRenderer> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorSpriteRendererTween TweenColor(this SpriteRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorSpriteRendererTween, SpriteRenderer>(options, optionsMode);
        }

        public static IEnumerable<ColorSpriteRendererTween> TweensColor(this IEnumerable<SpriteRenderer> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static HorizontalFlipSpriteRendererTween TweenHorizontalFlip(this SpriteRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<HorizontalFlipSpriteRendererTween, SpriteRenderer, bool>(options, optionsMode);
        }

        public static IEnumerable<HorizontalFlipSpriteRendererTween> TweensHorizontalFlip(this IEnumerable<SpriteRenderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<HorizontalFlipSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenHorizontalFlip(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VerticalFlipSpriteRendererTween TweenVerticalFlip(this SpriteRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<VerticalFlipSpriteRendererTween, SpriteRenderer, bool>(options, optionsMode);
        }

        public static IEnumerable<VerticalFlipSpriteRendererTween> TweensVerticalFlip(this IEnumerable<SpriteRenderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<VerticalFlipSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVerticalFlip(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSize(this SpriteRenderer self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SizeSpriteRendererTween, SpriteRenderer, Vector2>(options, optionsMode);
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSize(this IEnumerable<SpriteRenderer> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSize(this SpriteRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(options, optionsMode);
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSize(this IEnumerable<SpriteRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSizeX(this SpriteRenderer self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSizeX(this IEnumerable<SpriteRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeX(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSizeY(this SpriteRenderer self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSizeY(this IEnumerable<SpriteRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeY(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}