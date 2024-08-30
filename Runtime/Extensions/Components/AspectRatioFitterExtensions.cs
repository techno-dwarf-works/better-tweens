using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class AspectRatioFitterExtensions
    {
        public static AspectRatioFitterTween TweenAspectRatio(this AspectRatioFitter self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectRatioFitterTween, AspectRatioFitter, float>(duration, options, optionsMode);
        }

        public static IEnumerable<AspectRatioFitterTween> TweensAspectRatio(this IEnumerable<AspectRatioFitter> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<AspectRatioFitterTween>();
            }

            var tweens = new List<AspectRatioFitterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAspectRatio(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}