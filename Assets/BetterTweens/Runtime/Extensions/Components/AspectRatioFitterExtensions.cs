using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class AspectRatioFitterExtensions
    {
        public static AspectRatioFitterTween TweenAspectRatio(this AspectRatioFitter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectRatioFitterTween, AspectRatioFitter, float>(options, optionsMode);
        }

        public static IEnumerable<AspectRatioFitterTween> TweensAspectRatio(this IEnumerable<AspectRatioFitter> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AspectRatioFitterTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAspectRatio(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}