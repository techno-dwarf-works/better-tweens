using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class LayoutElementExtensions
    {
        public static FlexibleSizeLayoutElementTween TweenFlexibleSize(this LayoutElement self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<FlexibleSizeLayoutElementTween, LayoutElement, Vector2>(options, optionsMode);
        }

        public static IgnoreLayoutElementTween TweenIgnore(this LayoutElement self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreLayoutElementTween, LayoutElement, bool>(options, optionsMode);
        }

        public static MinSizeLayoutElementTween TweenMinSize(this LayoutElement self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinSizeLayoutElementTween, LayoutElement, Vector2>(options, optionsMode);
        }

        public static PreferredSizeLayoutElementTween TweenPreferredSize(this LayoutElement self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PreferredSizeLayoutElementTween, LayoutElement, Vector2>(options, optionsMode);
        }

        public static PriorityLayoutElementTween TweenPriority(this LayoutElement self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityLayoutElementTween, LayoutElement, int>(options, optionsMode);
        }
    }
}