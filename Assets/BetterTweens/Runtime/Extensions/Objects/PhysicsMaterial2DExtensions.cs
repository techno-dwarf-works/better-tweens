using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class PhysicsMaterial2DExtensions
    {
        public static BouncinessPhysicsMaterial2DTween TweenBounciness(this PhysicsMaterial2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BouncinessPhysicsMaterial2DTween, PhysicsMaterial2D, float>(options, optionsMode);
        }

        public static FrictionPhysicsMaterial2DTween TweenFriction(this PhysicsMaterial2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrictionPhysicsMaterial2DTween, PhysicsMaterial2D, float>(options, optionsMode);
        }
    }
}