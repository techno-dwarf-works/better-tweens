using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class MaskExtensions
    {
        public static ShowGraphicMaskTween TweenShowGraphic(this Mask self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShowGraphicMaskTween, Mask, bool>(options, optionsMode);
        }
    }
}