using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class MaskableGraphicExtensions
    {
        public static MaskableGraphicTween TweenMaskable(this MaskableGraphic self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaskableGraphicTween, MaskableGraphic, bool>(options, optionsMode);
        }

        public static MaskingGraphicTween TweenMasking(this MaskableGraphic self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaskingGraphicTween, MaskableGraphic, bool>(options, optionsMode);
        }
    }
}