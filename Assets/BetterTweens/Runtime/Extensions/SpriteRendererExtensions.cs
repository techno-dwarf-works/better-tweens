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

        public static ColorSpriteRendererTween TweenColor(this SpriteRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorSpriteRendererTween, SpriteRenderer>(options, optionsMode);
        }

        public static HorizontalFlipSpriteRendererTween TweenHorizontalFlip(this SpriteRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<HorizontalFlipSpriteRendererTween, SpriteRenderer, bool>(options, optionsMode);
        }

        public static VerticalFlipSpriteRendererTween TweenVerticalFlip(this SpriteRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<VerticalFlipSpriteRendererTween, SpriteRenderer, bool>(options, optionsMode);
        }

        public static SizeSpriteRendererTween TweenSize(this SpriteRenderer self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SizeSpriteRendererTween, SpriteRenderer, Vector2>(options, optionsMode);
        }

        public static SizeSpriteRendererTween TweenSize(this SpriteRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(options, optionsMode);
        }

        public static SizeSpriteRendererTween TweenSizeX(this SpriteRenderer self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);
            
            return tween;
        }

        public static SizeSpriteRendererTween TweenSizeY(this SpriteRenderer self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<SizeSpriteRendererTween, SpriteRenderer>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }
    }
}