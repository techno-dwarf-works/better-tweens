﻿using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class GameObjectExtensions
    {
        public static ActiveGameObjectTween TweenActive(this GameObject self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ActiveGameObjectTween, GameObject, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<ActiveGameObjectTween> TweensActive(this IEnumerable<GameObject> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ActiveGameObjectTween>();
            }

            var tweens = new List<ActiveGameObjectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenActive(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}