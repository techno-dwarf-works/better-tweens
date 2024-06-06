using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using Better.Tweens.Runtime.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ShadowExtensions
    {
        public static EffectColorShadowTween TweenEffectColor(this Shadow self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EffectColorShadowTween, Shadow, Color, ColorOptions>(options, optionsMode);
        }

        public static EffectColorShadowTween TweenEffectColor(this Shadow self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EffectColorShadowTween, Shadow>(options, optionsMode);
        }

        public static EffectDistanceShadowTween TweenEffectDistance(this Shadow self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<EffectDistanceShadowTween, Shadow, Vector2>(options, optionsMode);
        }

        public static EffectDistanceShadowTween TweenEffectDistance(this Shadow self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<EffectDistanceShadowTween, Shadow>(options, optionsMode);
        }

        public static EffectDistanceShadowTween TweenEffectDistanceX(this Shadow self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<EffectDistanceShadowTween, Shadow>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static EffectDistanceShadowTween TweenEffectDistanceY(this Shadow self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<EffectDistanceShadowTween, Shadow>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static UseAlphaShadowTween TweenUseAlpha(this Shadow self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseAlphaShadowTween, Shadow, bool>(options, optionsMode);
        }
    }
}