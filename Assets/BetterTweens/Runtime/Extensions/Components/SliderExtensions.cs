﻿using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class SliderExtensions
    {
        public static NormalizedValueSliderTween TweenNormalizedValue(this Slider self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NormalizedValueSliderTween, Slider, float>(duration, options, optionsMode);
        }

        public static IEnumerable<NormalizedValueSliderTween> TweensNormalizedValue(this IEnumerable<Slider> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NormalizedValueSliderTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNormalizedValue(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}