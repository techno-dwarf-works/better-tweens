using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class RectMask2DExtensions
    {
        public static PaddingRectMaskTween TweenPadding(this RectMask2D self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PaddingRectMaskTween, RectMask2D, Vector4>(options, optionsMode);
        }

        public static SoftnessRectMaskTween TweenSoftness(this RectMask2D self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SoftnessRectMaskTween, RectMask2D, Vector2>(options, optionsMode);
        }
    }
}