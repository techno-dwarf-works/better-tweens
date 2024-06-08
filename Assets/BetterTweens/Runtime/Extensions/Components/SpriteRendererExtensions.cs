using System.Collections.Generic;
using Better.Commons.Runtime.Enums;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class SpriteRendererExtensions
    {
        public static ColorSpriteRendererTween TweenColor(this SpriteRenderer self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorSpriteRendererTween, SpriteRenderer, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorSpriteRendererTween> TweensColor(this IEnumerable<SpriteRenderer> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorSpriteRendererTween TweenColor(this SpriteRenderer self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorSpriteRendererTween, SpriteRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorSpriteRendererTween> TweensColor(this IEnumerable<SpriteRenderer> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static HorizontalFlipSpriteRendererTween TweenHorizontalFlip(this SpriteRenderer self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<HorizontalFlipSpriteRendererTween, SpriteRenderer, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<HorizontalFlipSpriteRendererTween> TweensHorizontalFlip(this IEnumerable<SpriteRenderer> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<HorizontalFlipSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenHorizontalFlip(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VerticalFlipSpriteRendererTween TweenVerticalFlip(this SpriteRenderer self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<VerticalFlipSpriteRendererTween, SpriteRenderer, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<VerticalFlipSpriteRendererTween> TweensVerticalFlip(this IEnumerable<SpriteRenderer> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<VerticalFlipSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVerticalFlip(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSize(this SpriteRenderer self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SizeSpriteRendererTween, SpriteRenderer, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSize(this IEnumerable<SpriteRenderer> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSize(this SpriteRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSize(this IEnumerable<SpriteRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSizeX(this SpriteRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.Y);

            return tween;
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSizeX(this IEnumerable<SpriteRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SizeSpriteRendererTween TweenSizeY(this SpriteRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.X);

            return tween;
        }

        public static IEnumerable<SizeSpriteRendererTween> TweensSizeY(this IEnumerable<SpriteRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SizeSpriteRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSizeY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}