using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class CanvasGroupExtensions
    {
        public static BlocksRaycastsCanvasGroupTween TweenBlocksRaycasts(this CanvasGroup self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<BlocksRaycastsCanvasGroupTween, CanvasGroup, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<BlocksRaycastsCanvasGroupTween> TweensBlocksRaycasts(this IEnumerable<CanvasGroup> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BlocksRaycastsCanvasGroupTween>();
            }

            var tweens = new List<BlocksRaycastsCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBlocksRaycasts(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InteractableCanvasGroupTween TweenInteractable(this CanvasGroup self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<InteractableCanvasGroupTween, CanvasGroup, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<InteractableCanvasGroupTween> TweensInteractable(this IEnumerable<CanvasGroup> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<InteractableCanvasGroupTween>();
            }

            var tweens = new List<InteractableCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInteractable(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FadeCanvasGroupTween TweenFade(this CanvasGroup self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FadeCanvasGroupTween, CanvasGroup, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FadeCanvasGroupTween> TweensFade(this IEnumerable<CanvasGroup> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FadeCanvasGroupTween>();
            }

            var tweens = new List<FadeCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFade(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IgnoreParentCanvasGroupTween TweenIgnoreParent(this CanvasGroup self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<IgnoreParentCanvasGroupTween, CanvasGroup, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<IgnoreParentCanvasGroupTween> TweensIgnoreParent(this IEnumerable<CanvasGroup> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<IgnoreParentCanvasGroupTween>();
            }

            var tweens = new List<IgnoreParentCanvasGroupTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIgnoreParent(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}