using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class CanvasGroupExtensions
    {
        public static BlocksRaycastsCanvasGroupTween TweenBlocksRaycasts(this CanvasGroup self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BlocksRaycastsCanvasGroupTween, CanvasGroup, bool>(options, optionsMode);
        }

        public static InteractableCanvasGroupTween TweenInteractable(this CanvasGroup self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<InteractableCanvasGroupTween, CanvasGroup, bool>(options, optionsMode);
        }

        public static FadeCanvasGroupTween TweenFade(this CanvasGroup self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeCanvasGroupTween, CanvasGroup, float>(options, optionsMode);
        }

        public static IgnoreParentCanvasGroupTween TweenIgnoreParent(this CanvasGroup self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreParentCanvasGroupTween, CanvasGroup, bool>(options, optionsMode);
        }
    }
}