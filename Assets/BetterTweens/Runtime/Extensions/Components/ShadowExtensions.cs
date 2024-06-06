using System.Collections.Generic;
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

        public static IEnumerable<EffectColorShadowTween> TweensEffectColor(this IEnumerable<Shadow> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectColorShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectColorShadowTween TweenEffectColor(this Shadow self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EffectColorShadowTween, Shadow>(options, optionsMode);
        }

        public static IEnumerable<EffectColorShadowTween> TweensEffectColor(this IEnumerable<Shadow> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectColorShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistance(this Shadow self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<EffectDistanceShadowTween, Shadow, Vector2>(options, optionsMode);
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistance(this IEnumerable<Shadow> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistance(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistance(this Shadow self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<EffectDistanceShadowTween, Shadow>(options, optionsMode);
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistance(this IEnumerable<Shadow> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistance(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistanceX(this Shadow self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<EffectDistanceShadowTween, Shadow>(options, optionsMode);
            tween.AddConstraint(XYAxis.Y);

            return tween;
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistanceX(this IEnumerable<Shadow> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistanceX(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistanceY(this Shadow self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<EffectDistanceShadowTween, Shadow>(options, optionsMode);
            tween.AddConstraint(XYAxis.X);

            return tween;
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistanceY(this IEnumerable<Shadow> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistanceY(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseAlphaShadowTween TweenUseAlpha(this Shadow self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseAlphaShadowTween, Shadow, bool>(options, optionsMode);
        }

        public static IEnumerable<UseAlphaShadowTween> TweensUseAlpha(this IEnumerable<Shadow> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseAlphaShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseAlpha(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}