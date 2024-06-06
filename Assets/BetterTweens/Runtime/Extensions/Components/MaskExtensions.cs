using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class MaskExtensions
    {
        public static ShowGraphicMaskTween TweenShowGraphic(this Mask self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShowGraphicMaskTween, Mask, bool>(options, optionsMode);
        }

        public static IEnumerable<ShowGraphicMaskTween> TweensShowGraphic(this IEnumerable<Mask> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShowGraphicMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShowGraphic(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}