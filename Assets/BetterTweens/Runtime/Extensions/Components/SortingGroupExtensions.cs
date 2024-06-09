using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine.Rendering;

namespace Better.Tweens.Runtime
{
    public static class SortingGroupExtensions
    {
        public static OrderSortingGroupTween TweenOrderSorting(this SortingGroup self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrderSortingGroupTween, SortingGroup, int>(duration, options, optionsMode);
        }

        public static IEnumerable<OrderSortingGroupTween> TweensOrderSorting(this IEnumerable<SortingGroup> self, float duration, int options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<OrderSortingGroupTween>();
            }

            var tweens = new List<OrderSortingGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrderSorting(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}