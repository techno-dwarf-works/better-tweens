using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class PhysicMaterialExtensions
    {
        public static BouncinessPhysicMaterialTween TweenBounciness(this PhysicMaterial self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BouncinessPhysicMaterialTween, PhysicMaterial, float>(options, optionsMode);
        }

        public static DynamicFrictionPhysicMaterialTween TweenDynamicFriction(this PhysicMaterial self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DynamicFrictionPhysicMaterialTween, PhysicMaterial, float>(options, optionsMode);
        }

        public static StaticFrictionPhysicMaterialTween TweenStaticFriction(this PhysicMaterial self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StaticFrictionPhysicMaterialTween, PhysicMaterial, float>(options, optionsMode);
        }
    }
}