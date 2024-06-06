using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class SpriteMaskExtensions
    {
        public static AlphaCutoffSpriteMaskTween TweenAlphaCutoff(this SpriteMask self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AlphaCutoffSpriteMaskTween, SpriteMask, float>(options, optionsMode);
        }

        public static BackSortingOrderSpriteMaskTween TweenBackSortingOrder(this SpriteMask self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<BackSortingOrderSpriteMaskTween, SpriteMask, int>(options, optionsMode);
        }

        public static CustomRangeSpriteMaskTween TweenCustomRange(this SpriteMask self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<CustomRangeSpriteMaskTween, SpriteMask, bool>(options, optionsMode);
        }

        public static FrontSortingOrderSpriteMaskTween TweenFrontSortingOrder(this SpriteMask self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrontSortingOrderSpriteMaskTween, SpriteMask, int>(options, optionsMode);
        }
    }
}