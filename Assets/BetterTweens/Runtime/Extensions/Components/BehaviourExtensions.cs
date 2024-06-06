using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class BehaviourExtensions
    {
        public static EnableBehaviourTween TweenEnable(this Behaviour self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EnableBehaviourTween, Behaviour, bool>(options, optionsMode);
        }
    }
}