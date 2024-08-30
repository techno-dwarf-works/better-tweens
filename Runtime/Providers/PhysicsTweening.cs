using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class PhysicsTweening
    {
        public static GravityPhysicsTween TweenGravity(float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            var tween = new GravityPhysicsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static ClothGravityPhysicsTween TweenClothGravity(float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            var tween = new ClothGravityPhysicsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static AutoSimulationPhysicsTween TweenAutoSimulation(float duration, bool options, OptionsMode optionsMode = default)
        {
            var tween = new AutoSimulationPhysicsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }
    }
}