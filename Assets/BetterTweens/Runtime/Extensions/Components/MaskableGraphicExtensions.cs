using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class MaskableGraphicExtensions
    {
        public static MaskableGraphicTween TweenMaskable(this MaskableGraphic self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaskableGraphicTween, MaskableGraphic, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<MaskableGraphicTween> TweensMaskable(this IEnumerable<MaskableGraphic> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MaskableGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaskable(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaskingGraphicTween TweenMasking(this MaskableGraphic self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaskingGraphicTween, MaskableGraphic, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<MaskingGraphicTween> TweensMasking(this IEnumerable<MaskableGraphic> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MaskingGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMasking(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}