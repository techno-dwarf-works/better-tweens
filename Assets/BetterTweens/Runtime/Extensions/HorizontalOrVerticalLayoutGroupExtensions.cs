using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public static class HorizontalOrVerticalLayoutGroupExtensions
    {
        public static LineSpacingLayoutGroupTween TweenLineSpacing(this HorizontalOrVerticalLayoutGroup self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<LineSpacingLayoutGroupTween, HorizontalOrVerticalLayoutGroup, float>(options, optionsMode);
        }
    }
}