using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class RectMask2DExtensions
    {
        public static PaddingRectMaskTween TweenPadding(this RectMask2D self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PaddingRectMaskTween, RectMask2D, Vector4>(options, optionsMode);
        }

        public static IEnumerable<PaddingRectMaskTween> TweensPadding(this IEnumerable<RectMask2D> self, Vector4 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PaddingRectMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPadding(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SoftnessRectMaskTween TweenSoftness(this RectMask2D self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SoftnessRectMaskTween, RectMask2D, Vector2>(options, optionsMode);
        }

        public static IEnumerable<SoftnessRectMaskTween> TweensSoftness(this IEnumerable<RectMask2D> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SoftnessRectMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSoftness(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}