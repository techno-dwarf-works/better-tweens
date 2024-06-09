using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class GraphicExtensions
    {
        public static ColorGraphicTween TweenColor(this Graphic self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorGraphicTween, Graphic, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorGraphicTween> TweensColor(this IEnumerable<Graphic> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorGraphicTween>();
            }

            var tweens = new List<ColorGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorGraphicTween TweenColor(this Graphic self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorGraphicTween, Graphic>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorGraphicTween> TweensColor(this IEnumerable<Graphic> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorGraphicTween>();
            }

            var tweens = new List<ColorGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FadeGraphicTween TweenFade(this Graphic self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeGraphicTween, Graphic, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FadeGraphicTween> TweensFade(this IEnumerable<Graphic> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FadeGraphicTween>();
            }

            var tweens = new List<FadeGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFade(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RaycastPaddingGraphicTween TweenRaycastPadding(this Graphic self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<RaycastPaddingGraphicTween, Graphic, Vector4>(duration, options, optionsMode);
        }

        public static IEnumerable<RaycastPaddingGraphicTween> TweensRaycastPadding(this IEnumerable<Graphic> self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<RaycastPaddingGraphicTween>();
            }

            var tweens = new List<RaycastPaddingGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRaycastPadding(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RaycastTargetGraphicTween TweenRaycastTarget(this Graphic self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<RaycastTargetGraphicTween, Graphic, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<RaycastTargetGraphicTween> TweensRaycastTarget(this IEnumerable<Graphic> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<RaycastTargetGraphicTween>();
            }

            var tweens = new List<RaycastTargetGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRaycastTarget(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}