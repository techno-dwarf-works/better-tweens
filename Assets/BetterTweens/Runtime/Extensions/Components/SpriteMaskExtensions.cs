using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class SpriteMaskExtensions
    {
        public static AlphaCutoffSpriteMaskTween TweenAlphaCutoff(this SpriteMask self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AlphaCutoffSpriteMaskTween, SpriteMask, float>(options, optionsMode);
        }

        public static IEnumerable<AlphaCutoffSpriteMaskTween> TweensAlphaCutoff(this IEnumerable<SpriteMask> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AlphaCutoffSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAlphaCutoff(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BackSortingOrderSpriteMaskTween TweenBackSortingOrder(this SpriteMask self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<BackSortingOrderSpriteMaskTween, SpriteMask, int>(options, optionsMode);
        }

        public static IEnumerable<BackSortingOrderSpriteMaskTween> TweensBackSortingOrder(this IEnumerable<SpriteMask> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BackSortingOrderSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBackSortingOrder(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CustomRangeSpriteMaskTween TweenCustomRange(this SpriteMask self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<CustomRangeSpriteMaskTween, SpriteMask, bool>(options, optionsMode);
        }

        public static IEnumerable<CustomRangeSpriteMaskTween> TweensCustomRange(this IEnumerable<SpriteMask> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<CustomRangeSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCustomRange(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FrontSortingOrderSpriteMaskTween TweenFrontSortingOrder(this SpriteMask self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrontSortingOrderSpriteMaskTween, SpriteMask, int>(options, optionsMode);
        }

        public static IEnumerable<FrontSortingOrderSpriteMaskTween> TweensFrontSortingOrder(this IEnumerable<SpriteMask> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FrontSortingOrderSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFrontSortingOrder(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}