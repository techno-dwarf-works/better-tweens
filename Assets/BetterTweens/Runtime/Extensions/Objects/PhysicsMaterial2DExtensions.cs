using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class PhysicsMaterial2DExtensions
    {
        public static BouncinessPhysicsMaterial2DTween TweenBounciness(this PhysicsMaterial2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BouncinessPhysicsMaterial2DTween, PhysicsMaterial2D, float>(options, optionsMode);
        }

        public static IEnumerable<BouncinessPhysicsMaterial2DTween> TweensTweenBounciness(this IEnumerable<PhysicsMaterial2D> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BouncinessPhysicsMaterial2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBounciness(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FrictionPhysicsMaterial2DTween TweenFriction(this PhysicsMaterial2D self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FrictionPhysicsMaterial2DTween, PhysicsMaterial2D, float>(options, optionsMode);
        }

        public static IEnumerable<FrictionPhysicsMaterial2DTween> TweensTweenFriction(this IEnumerable<PhysicsMaterial2D> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FrictionPhysicsMaterial2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFriction(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}