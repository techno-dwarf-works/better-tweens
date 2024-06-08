using System.Collections.Generic;
using Better.Commons.Runtime.Enums;
using Better.Tweens.Runtime.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ShadowExtensions
    {
        public static EffectColorShadowTween TweenEffectColor(this Shadow self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EffectColorShadowTween, Shadow, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<EffectColorShadowTween> TweensEffectColor(this IEnumerable<Shadow> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectColorShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectColorShadowTween TweenEffectColor(this Shadow self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EffectColorShadowTween, Shadow>(duration, options, optionsMode);
        }

        public static IEnumerable<EffectColorShadowTween> TweensEffectColor(this IEnumerable<Shadow> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectColorShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistance(this Shadow self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<EffectDistanceShadowTween, Shadow, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistance(this IEnumerable<Shadow> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistance(this Shadow self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector2<EffectDistanceShadowTween, Shadow>(duration, options, optionsMode);
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistance(this IEnumerable<Shadow> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistanceX(this Shadow self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<EffectDistanceShadowTween, Shadow>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.Y);

            return tween;
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistanceX(this IEnumerable<Shadow> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistanceX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EffectDistanceShadowTween TweenEffectDistanceY(this Shadow self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<EffectDistanceShadowTween, Shadow>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.X);

            return tween;
        }

        public static IEnumerable<EffectDistanceShadowTween> TweensEffectDistanceY(this IEnumerable<Shadow> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EffectDistanceShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEffectDistanceY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseAlphaShadowTween TweenUseAlpha(this Shadow self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseAlphaShadowTween, Shadow, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<UseAlphaShadowTween> TweensUseAlpha(this IEnumerable<Shadow> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseAlphaShadowTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseAlpha(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}