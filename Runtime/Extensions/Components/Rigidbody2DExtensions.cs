using System;
using System.Collections.Generic;
using Better.Commons.Runtime.Enums;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class Rigidbody2DExtensions
    {
        public static AngularDragRigidbody2DTween TweenAngularDrag(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularDragRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<AngularDragRigidbody2DTween> TweensAngularDrag(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<AngularDragRigidbody2DTween>();
            }

            var tweens = new List<AngularDragRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAngularDrag(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AngularVelocityRigidbody2DTween TweenAngularVelocity(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularVelocityRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<AngularVelocityRigidbody2DTween> TweensAngularVelocity(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<AngularVelocityRigidbody2DTween>();
            }

            var tweens = new List<AngularVelocityRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAngularVelocity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CenterOfMassRigidbody2DTween TweenCenterOfMass(this Rigidbody2D self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<CenterOfMassRigidbody2DTween, Rigidbody2D, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<CenterOfMassRigidbody2DTween> TweensCenterOfMass(this IEnumerable<Rigidbody2D> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<CenterOfMassRigidbody2DTween>();
            }

            var tweens = new List<CenterOfMassRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCenterOfMass(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DragRigidbody2DTween TweenDrag(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DragRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DragRigidbody2DTween> TweensDrag(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<DragRigidbody2DTween>();
            }

            var tweens = new List<DragRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDrag(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InertiaRigidbody2DTween TweenInertia(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<InertiaRigidbody2DTween> TweensInertia(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<InertiaRigidbody2DTween>();
            }

            var tweens = new List<InertiaRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInertia(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static KinematicRigidbody2DTween TweenKinematic(this Rigidbody2D self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<KinematicRigidbody2DTween, Rigidbody2D, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<KinematicRigidbody2DTween> TweensKinematic(this IEnumerable<Rigidbody2D> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<KinematicRigidbody2DTween>();
            }

            var tweens = new List<KinematicRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenKinematic(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MassRigidbody2DTween TweenMass(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MassRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MassRigidbody2DTween> TweensMass(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<MassRigidbody2DTween>();
            }

            var tweens = new List<MassRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMass(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbody2DTween TweenPosition(this Rigidbody2D self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionRigidbody2DTween, Rigidbody2D, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<PositionRigidbody2DTween> TweensPosition(this IEnumerable<Rigidbody2D> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionRigidbody2DTween>();
            }

            var tweens = new List<PositionRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbody2DTween TweenPositionX(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PositionRigidbody2DTween, Rigidbody2D>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.Y);

            return tween;
        }

        public static IEnumerable<PositionRigidbody2DTween> TweensPositionX(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionRigidbody2DTween>();
            }

            var tweens = new List<PositionRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbody2DTween TweenPositionY(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector2<PositionRigidbody2DTween, Rigidbody2D>(duration, options, optionsMode);
            tween.AddConstraint(Vector2Axis.X);

            return tween;
        }

        public static IEnumerable<PositionRigidbody2DTween> TweensPositionY(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionRigidbody2DTween>();
            }

            var tweens = new List<PositionRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RotationRigidbody2DTween TweenRotation(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<RotationRigidbody2DTween> TweensRotation(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<RotationRigidbody2DTween>();
            }

            var tweens = new List<RotationRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRotation(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static GravityScaleRigidbody2DTween TweenGravityScale(this Rigidbody2D self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<GravityScaleRigidbody2DTween, Rigidbody2D, float>(duration, options, optionsMode);
        }

        public static IEnumerable<GravityScaleRigidbody2DTween> TweensGravityScale(this IEnumerable<Rigidbody2D> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<GravityScaleRigidbody2DTween>();
            }

            var tweens = new List<GravityScaleRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenGravityScale(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VelocityRigidbody2DTween TweenVelocity(this Rigidbody2D self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VelocityRigidbody2DTween, Rigidbody2D, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<VelocityRigidbody2DTween> TweensVelocity(this IEnumerable<Rigidbody2D> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<VelocityRigidbody2DTween>();
            }

            var tweens = new List<VelocityRigidbody2DTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVelocity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}