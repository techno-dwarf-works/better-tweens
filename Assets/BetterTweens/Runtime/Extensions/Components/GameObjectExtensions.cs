using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class GameObjectExtensions
    {
        public static ActiveGameObjectTween TweenActive(this GameObject self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ActiveGameObjectTween, GameObject, bool>(options, optionsMode);
        }

        public static IEnumerable<ActiveGameObjectTween> TweensActive(this IEnumerable<GameObject> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ActiveGameObjectTween>();
            foreach (var target in self)
            {
                var tween = target.TweenActive(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}