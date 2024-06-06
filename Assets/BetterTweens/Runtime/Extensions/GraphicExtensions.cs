using Better.Tweens.Runtime.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class GraphicExtensions
    {
        public static ColorGraphicTween TweenColor(this Graphic self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorGraphicTween, Graphic, Color, ColorOptions>(options, optionsMode);
        }

        public static ColorGraphicTween TweenColor(this Graphic self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorGraphicTween, Graphic>(options, optionsMode);
        }

        public static FadeGraphicTween TweenFade(this Graphic self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeGraphicTween, Graphic, float>(options, optionsMode);
        }

        public static RaycastPaddingGraphicTween TweenRaycastPadding(this Graphic self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<RaycastPaddingGraphicTween, Graphic, Vector4>(options, optionsMode);
        }

        public static RaycastTargetGraphicTween TweenRaycastTarget(this Graphic self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<RaycastTargetGraphicTween, Graphic, bool>(options, optionsMode);
        }
    }
}