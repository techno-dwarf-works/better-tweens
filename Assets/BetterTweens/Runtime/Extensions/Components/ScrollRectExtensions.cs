using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ScrollRectExtensions
    {
        public static HorizontalNormalizedPositionScrollRectTween TweenHorizontalNormalizedPosition(this ScrollRect self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<HorizontalNormalizedPositionScrollRectTween, ScrollRect, float>(options, optionsMode);
        }

        public static NormalizedPositionScrollRectTween TweenNormalizedPosition(this ScrollRect self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<NormalizedPositionScrollRectTween, ScrollRect, Vector2>(options, optionsMode);
        }

        public static VerticalNormalizedPositionScrollRectTween TweenVerticalNormalizedPosition(this ScrollRect self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<VerticalNormalizedPositionScrollRectTween, ScrollRect, float>(options, optionsMode);
        }
    }
}