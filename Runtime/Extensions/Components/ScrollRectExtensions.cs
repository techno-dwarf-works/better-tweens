using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ScrollRectExtensions
    {
        public static HorizontalNormalizedPositionScrollRectTween TweenHorizontalNormalizedPosition(this ScrollRect self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HorizontalNormalizedPositionScrollRectTween, ScrollRect, float>(duration, options, optionsMode);
        }

        public static IEnumerable<HorizontalNormalizedPositionScrollRectTween> TweensHorizontalNormalizedPosition(this IEnumerable<ScrollRect> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<HorizontalNormalizedPositionScrollRectTween>();
            }

            var tweens = new List<HorizontalNormalizedPositionScrollRectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenHorizontalNormalizedPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NormalizedPositionScrollRectTween TweenNormalizedPosition(this ScrollRect self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<NormalizedPositionScrollRectTween, ScrollRect, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<NormalizedPositionScrollRectTween> TweensNormalizedPosition(this IEnumerable<ScrollRect> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<NormalizedPositionScrollRectTween>();
            }

            var tweens = new List<NormalizedPositionScrollRectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNormalizedPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VerticalNormalizedPositionScrollRectTween TweenVerticalNormalizedPosition(this ScrollRect self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<VerticalNormalizedPositionScrollRectTween, ScrollRect, float>(duration, options, optionsMode);
        }

        public static IEnumerable<VerticalNormalizedPositionScrollRectTween> TweensVerticalNormalizedPosition(this IEnumerable<ScrollRect> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<VerticalNormalizedPositionScrollRectTween>();
            }

            var tweens = new List<VerticalNormalizedPositionScrollRectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVerticalNormalizedPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}