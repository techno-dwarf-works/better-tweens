using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ScrollRectExtensions
    {
        public static HorizontalNormalizedPositionScrollRectTween TweenHorizontalNormalizedPosition(this ScrollRect self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HorizontalNormalizedPositionScrollRectTween, ScrollRect, float>(options, optionsMode);
        }

        public static IEnumerable<HorizontalNormalizedPositionScrollRectTween> TweensHorizontalNormalizedPosition(this IEnumerable<ScrollRect> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<HorizontalNormalizedPositionScrollRectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenHorizontalNormalizedPosition(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NormalizedPositionScrollRectTween TweenNormalizedPosition(this ScrollRect self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<NormalizedPositionScrollRectTween, ScrollRect, Vector2>(options, optionsMode);
        }

        public static IEnumerable<NormalizedPositionScrollRectTween> TweensNormalizedPosition(this IEnumerable<ScrollRect> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NormalizedPositionScrollRectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNormalizedPosition(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VerticalNormalizedPositionScrollRectTween TweenVerticalNormalizedPosition(this ScrollRect self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<VerticalNormalizedPositionScrollRectTween, ScrollRect, float>(options, optionsMode);
        }

        public static IEnumerable<VerticalNormalizedPositionScrollRectTween> TweensVerticalNormalizedPosition(this IEnumerable<ScrollRect> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<VerticalNormalizedPositionScrollRectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVerticalNormalizedPosition(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}