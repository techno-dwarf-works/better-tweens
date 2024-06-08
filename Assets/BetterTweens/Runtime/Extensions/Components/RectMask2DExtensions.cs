using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class RectMask2DExtensions
    {
        public static PaddingRectMaskTween TweenPadding(this RectMask2D self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PaddingRectMaskTween, RectMask2D, Vector4>(duration, options, optionsMode);
        }

        public static IEnumerable<PaddingRectMaskTween> TweensPadding(this IEnumerable<RectMask2D> self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PaddingRectMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPadding(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SoftnessRectMaskTween TweenSoftness(this RectMask2D self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SoftnessRectMaskTween, RectMask2D, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<SoftnessRectMaskTween> TweensSoftness(this IEnumerable<RectMask2D> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<SoftnessRectMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSoftness(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}