using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class ImageExtensions
    {
        public static FillAmountImageTween TweenFillAmount(this Image self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillAmountImageTween, Image, float>(options, optionsMode);
        }

        public static FillCenterImageTween TweenFillCenter(this Image self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillCenterImageTween, Image, bool>(options, optionsMode);
        }

        public static FillClockwiseImageTween TweenFillClockwise(this Image self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<FillClockwiseImageTween, Image, bool>(options, optionsMode);
        }

        public static PreserveAspectImageTween TweenPreserveAspect(this Image self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<PreserveAspectImageTween, Image, bool>(options, optionsMode);
        }
    }
}