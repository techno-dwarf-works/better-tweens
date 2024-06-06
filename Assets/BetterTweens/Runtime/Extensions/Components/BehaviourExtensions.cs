using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class BehaviourExtensions
    {
        public static EnableBehaviourTween TweenEnable(this Behaviour self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EnableBehaviourTween, Behaviour, bool>(options, optionsMode);
        }

        public static IEnumerable<EnableBehaviourTween> TweensEnable(this IEnumerable<Behaviour> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EnableBehaviourTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEnable(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}