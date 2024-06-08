﻿using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class MaskExtensions
    {
        public static ShowGraphicMaskTween TweenShowGraphic(this Mask self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShowGraphicMaskTween, Mask, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<ShowGraphicMaskTween> TweensShowGraphic(this IEnumerable<Mask> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<ShowGraphicMaskTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShowGraphic(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}