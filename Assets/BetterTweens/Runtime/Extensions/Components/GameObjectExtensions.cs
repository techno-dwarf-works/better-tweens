using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class GameObjectExtensions
    {
        public static ActiveGameObjectTween TweenActive(this GameObject self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ActiveGameObjectTween, GameObject, bool>(options, optionsMode);
        }
    }
}