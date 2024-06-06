using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class AspectRatioFitterExtensions
    {
        public static AspectRatioFitterTween TweenAspectRatio(this AspectRatioFitter self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectRatioFitterTween, AspectRatioFitter, float>(options, optionsMode);
        }
    }
}