using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ImageExtensions
    {
        public static FillAmountImageTween TweenFillAmount(this Image self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillAmountImageTween, Image, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FillAmountImageTween> TweensFillAmount(this IEnumerable<Image> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FillAmountImageTween>();
            }

            var tweens = new List<FillAmountImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFillAmount(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FillCenterImageTween TweenFillCenter(this Image self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillCenterImageTween, Image, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<FillCenterImageTween> TweensFillCenter(this IEnumerable<Image> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FillCenterImageTween>();
            }

            var tweens = new List<FillCenterImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFillCenter(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FillClockwiseImageTween TweenFillClockwise(this Image self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillClockwiseImageTween, Image, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<FillClockwiseImageTween> TweensFillClockwise(this IEnumerable<Image> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FillClockwiseImageTween>();
            }

            var tweens = new List<FillClockwiseImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFillClockwise(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PreserveAspectImageTween TweenPreserveAspect(this Image self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<PreserveAspectImageTween, Image, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<PreserveAspectImageTween> TweensPreserveAspect(this IEnumerable<Image> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PreserveAspectImageTween>();
            }

            var tweens = new List<PreserveAspectImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPreserveAspect(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}