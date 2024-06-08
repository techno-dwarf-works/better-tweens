using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class Physics2DTweening
    {
        public static GravityPhysics2DTween TweenAutoSimulation(float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            var tween = new GravityPhysics2DTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }
    }
}