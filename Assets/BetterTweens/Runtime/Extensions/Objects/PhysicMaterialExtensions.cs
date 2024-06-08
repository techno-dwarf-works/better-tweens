using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class PhysicMaterialExtensions
    {
        public static BouncinessPhysicMaterialTween TweenBounciness(this PhysicMaterial self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BouncinessPhysicMaterialTween, PhysicMaterial, float>(duration, options, optionsMode);
        }

        public static IEnumerable<BouncinessPhysicMaterialTween> TweensTweenBounciness(this IEnumerable<PhysicMaterial> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BouncinessPhysicMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBounciness(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DynamicFrictionPhysicMaterialTween TweenDynamicFriction(this PhysicMaterial self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DynamicFrictionPhysicMaterialTween, PhysicMaterial, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DynamicFrictionPhysicMaterialTween> TweensTweenDynamicFriction(this IEnumerable<PhysicMaterial> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DynamicFrictionPhysicMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDynamicFriction(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StaticFrictionPhysicMaterialTween TweenStaticFriction(this PhysicMaterial self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StaticFrictionPhysicMaterialTween, PhysicMaterial, float>(duration, options, optionsMode);
        }

        public static IEnumerable<StaticFrictionPhysicMaterialTween> TweensTweenStaticFriction(this IEnumerable<PhysicMaterial> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StaticFrictionPhysicMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStaticFriction(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}