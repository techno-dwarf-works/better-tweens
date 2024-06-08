﻿using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class HorizontalOrVerticalLayoutGroupExtensions
    {
        public static LineSpacingLayoutGroupTween TweenLineSpacing(this HorizontalOrVerticalLayoutGroup self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LineSpacingLayoutGroupTween, HorizontalOrVerticalLayoutGroup, float>(duration, options, optionsMode);
        }

        public static IEnumerable<LineSpacingLayoutGroupTween> TweensLineSpacing(this IEnumerable<HorizontalOrVerticalLayoutGroup> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<LineSpacingLayoutGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLineSpacing(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}