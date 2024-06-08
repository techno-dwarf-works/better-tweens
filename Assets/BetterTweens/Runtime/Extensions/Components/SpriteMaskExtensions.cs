using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class SpriteMaskExtensions
    {
        public static AlphaCutoffSpriteMaskTween TweenAlphaCutoff(this SpriteMask self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AlphaCutoffSpriteMaskTween, SpriteMask, float>(duration, options, optionsMode);
        }

        public static IEnumerable<AlphaCutoffSpriteMaskTween> TweensAlphaCutoff(this IEnumerable<SpriteMask> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AlphaCutoffSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAlphaCutoff(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BackSortingOrderSpriteMaskTween TweenBackSortingOrder(this SpriteMask self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<BackSortingOrderSpriteMaskTween, SpriteMask, int>(duration, options, optionsMode);
        }

        public static IEnumerable<BackSortingOrderSpriteMaskTween> TweensBackSortingOrder(this IEnumerable<SpriteMask> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<BackSortingOrderSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBackSortingOrder(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CustomRangeSpriteMaskTween TweenCustomRange(this SpriteMask self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<CustomRangeSpriteMaskTween, SpriteMask, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<CustomRangeSpriteMaskTween> TweensCustomRange(this IEnumerable<SpriteMask> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<CustomRangeSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCustomRange(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FrontSortingOrderSpriteMaskTween TweenFrontSortingOrder(this SpriteMask self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrontSortingOrderSpriteMaskTween, SpriteMask, int>(duration, options, optionsMode);
        }

        public static IEnumerable<FrontSortingOrderSpriteMaskTween> TweensFrontSortingOrder(this IEnumerable<SpriteMask> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<FrontSortingOrderSpriteMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFrontSortingOrder(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}