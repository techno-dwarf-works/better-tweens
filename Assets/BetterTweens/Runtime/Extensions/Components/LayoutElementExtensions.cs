using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class LayoutElementExtensions
    {
        public static FlexibleSizeLayoutElementTween TweenFlexibleSize(this LayoutElement self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<FlexibleSizeLayoutElementTween, LayoutElement, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<FlexibleSizeLayoutElementTween> TweensFlexibleSize(this IEnumerable<LayoutElement> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<FlexibleSizeLayoutElementTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFlexibleSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreLayoutElementTween TweenIgnore(this LayoutElement self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreLayoutElementTween, LayoutElement, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<IgnoreLayoutElementTween> TweensIgnore(this IEnumerable<LayoutElement> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<IgnoreLayoutElementTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnore(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MinSizeLayoutElementTween TweenMinSize(this LayoutElement self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinSizeLayoutElementTween, LayoutElement, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<MinSizeLayoutElementTween> TweensMinSize(this IEnumerable<LayoutElement> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MinSizeLayoutElementTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMinSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PreferredSizeLayoutElementTween TweenPreferredSize(this LayoutElement self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PreferredSizeLayoutElementTween, LayoutElement, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<PreferredSizeLayoutElementTween> TweensPreferredSize(this IEnumerable<LayoutElement> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PreferredSizeLayoutElementTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPreferredSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PriorityLayoutElementTween TweenPriority(this LayoutElement self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityLayoutElementTween, LayoutElement, int>(duration, options, optionsMode);
        }

        public static IEnumerable<PriorityLayoutElementTween> TweensPriority(this IEnumerable<LayoutElement> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PriorityLayoutElementTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPriority(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}