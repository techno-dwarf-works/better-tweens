using UnityEngine.Rendering;

namespace Better.Tweens.Runtime
{
    public static class SortingGroupExtensions
    {
        public static OrderSortingGroupTween TweenOrderSorting(this SortingGroup self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrderSortingGroupTween, SortingGroup, int>(options, optionsMode);
        }
    }
}