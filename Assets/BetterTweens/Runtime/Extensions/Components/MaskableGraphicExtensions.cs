using System.Collections.Generic;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class MaskableGraphicExtensions
    {
        public static MaskableGraphicTween TweenMaskable(this MaskableGraphic self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaskableGraphicTween, MaskableGraphic, bool>(options, optionsMode);
        }

        public static IEnumerable<MaskableGraphicTween> TweensMaskable(this IEnumerable<MaskableGraphic> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MaskableGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaskable(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaskingGraphicTween TweenMasking(this MaskableGraphic self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaskingGraphicTween, MaskableGraphic, bool>(options, optionsMode);
        }

        public static IEnumerable<MaskingGraphicTween> TweensMasking(this IEnumerable<MaskableGraphic> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MaskingGraphicTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMasking(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}