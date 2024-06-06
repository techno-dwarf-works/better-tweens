using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class CanvasGroupExtensions
    {
        public static BlocksRaycastsCanvasGroupTween TweenBlocksRaycasts(this CanvasGroup self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BlocksRaycastsCanvasGroupTween, CanvasGroup, bool>(options, optionsMode);
        }

        public static IEnumerable<BlocksRaycastsCanvasGroupTween> TweensBlocksRaycasts(this IEnumerable<CanvasGroup> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BlocksRaycastsCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBlocksRaycasts(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InteractableCanvasGroupTween TweenInteractable(this CanvasGroup self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<InteractableCanvasGroupTween, CanvasGroup, bool>(options, optionsMode);
        }

        public static IEnumerable<InteractableCanvasGroupTween> TweensInteractable(this IEnumerable<CanvasGroup> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<InteractableCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInteractable(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FadeCanvasGroupTween TweenFade(this CanvasGroup self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeCanvasGroupTween, CanvasGroup, float>(options, optionsMode);
        }

        public static IEnumerable<FadeCanvasGroupTween> TweensFade(this IEnumerable<CanvasGroup> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FadeCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFade(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreParentCanvasGroupTween TweenIgnoreParent(this CanvasGroup self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreParentCanvasGroupTween, CanvasGroup, bool>(options, optionsMode);
        }

        public static IEnumerable<IgnoreParentCanvasGroupTween> TweensIgnoreParent(this IEnumerable<CanvasGroup> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<IgnoreParentCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnoreParent(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}