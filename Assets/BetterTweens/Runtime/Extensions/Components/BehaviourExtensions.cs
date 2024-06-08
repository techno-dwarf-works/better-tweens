using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class BehaviourExtensions
    {
        public static EnableBehaviourTween TweenEnable(this Behaviour self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EnableBehaviourTween, Behaviour, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<EnableBehaviourTween> TweensEnable(this IEnumerable<Behaviour> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<EnableBehaviourTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEnable(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}