using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class GraphicExtensions
    {
        public static ColorGraphicTween TweenColor(this Graphic self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorGraphicTween, Graphic, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<ColorGraphicTween> TweensColor(this IEnumerable<Graphic> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorGraphicTween TweenColor(this Graphic self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorGraphicTween, Graphic>(options, optionsMode);
        }

        public static IEnumerable<ColorGraphicTween> TweensColor(this IEnumerable<Graphic> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FadeGraphicTween TweenFade(this Graphic self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeGraphicTween, Graphic, float>(options, optionsMode);
        }

        public static IEnumerable<FadeGraphicTween> TweensFade(this IEnumerable<Graphic> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FadeGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFade(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RaycastPaddingGraphicTween TweenRaycastPadding(this Graphic self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<RaycastPaddingGraphicTween, Graphic, Vector4>(options, optionsMode);
        }

        public static IEnumerable<RaycastPaddingGraphicTween> TweensRaycastPadding(this IEnumerable<Graphic> self, Vector4 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RaycastPaddingGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRaycastPadding(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RaycastTargetGraphicTween TweenRaycastTarget(this Graphic self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<RaycastTargetGraphicTween, Graphic, bool>(options, optionsMode);
        }

        public static IEnumerable<RaycastTargetGraphicTween> TweensRaycastTarget(this IEnumerable<Graphic> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RaycastTargetGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRaycastTarget(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}