using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ImageExtensions
    {
        public static FillAmountImageTween TweenFillAmount(this Image self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillAmountImageTween, Image, float>(options, optionsMode);
        }

        public static IEnumerable<FillAmountImageTween> TweensFillAmount(this IEnumerable<Image> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FillAmountImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFillAmount(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FillCenterImageTween TweenFillCenter(this Image self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillCenterImageTween, Image, bool>(options, optionsMode);
        }

        public static IEnumerable<FillCenterImageTween> TweensFillCenter(this IEnumerable<Image> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FillCenterImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFillCenter(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FillClockwiseImageTween TweenFillClockwise(this Image self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillClockwiseImageTween, Image, bool>(options, optionsMode);
        }

        public static IEnumerable<FillClockwiseImageTween> TweensFillClockwise(this IEnumerable<Image> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FillClockwiseImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFillClockwise(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PreserveAspectImageTween TweenPreserveAspect(this Image self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<PreserveAspectImageTween, Image, bool>(options, optionsMode);
        }

        public static IEnumerable<PreserveAspectImageTween> TweensPreserveAspect(this IEnumerable<Image> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PreserveAspectImageTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPreserveAspect(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}