using System.Collections.Generic;
using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class RigidbodyExtensions
    {
        public static AngularDragRigidbodyTween TweenAngularDrag(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularDragRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static IEnumerable<AngularDragRigidbodyTween> TweensAngularDrag(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AngularDragRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAngularDrag(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AngularVelocityRigidbodyTween TweenAngularVelocity(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularVelocityRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static IEnumerable<AngularVelocityRigidbodyTween> TweensAngularVelocity(this IEnumerable<Rigidbody> self, Vector3 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AngularVelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAngularVelocity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CenterOfMassRigidbodyTween TweenCenterOfMass(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<CenterOfMassRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static IEnumerable<CenterOfMassRigidbodyTween> TweensCenterOfMass(this IEnumerable<Rigidbody> self, Vector3 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<CenterOfMassRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCenterOfMass(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DragRigidbodyTween TweenDrag(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DragRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static IEnumerable<DragRigidbodyTween> TweensDrag(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DragRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDrag(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InertiaTensorRigidbodyTween TweenInertiaTensor(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaTensorRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static IEnumerable<InertiaTensorRigidbodyTween> TweensInertiaTensor(this IEnumerable<Rigidbody> self, Vector3 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<InertiaTensorRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInertiaTensor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InertiaTensorRotationRigidbodyTween TweenInertiaTensorRotation(this Rigidbody self, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaTensorRotationRigidbodyTween, Rigidbody, Quaternion>(options, optionsMode);
        }

        public static IEnumerable<InertiaTensorRotationRigidbodyTween> TweensInertiaTensorRotation(this IEnumerable<Rigidbody> self, Quaternion options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<InertiaTensorRotationRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInertiaTensorRotation(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static KinematicRigidbodyTween TweenKinematic(this Rigidbody self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<KinematicRigidbodyTween, Rigidbody, bool>(options, optionsMode);
        }

        public static IEnumerable<KinematicRigidbodyTween> TweensKinematic(this IEnumerable<Rigidbody> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<KinematicRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenKinematic(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MassRigidbodyTween TweenMass(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MassRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static IEnumerable<MassRigidbodyTween> TweensMass(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MassRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMass(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxAngularVelocityRigidbodyTween TweenMaxAngularVelocity(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxAngularVelocityRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static IEnumerable<MaxAngularVelocityRigidbodyTween> TweensMaxAngularVelocity(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MaxAngularVelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxAngularVelocity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxDepenetrationVelocityRigidbodyTween TweenMaxDepenetrationVelocity(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDepenetrationVelocityRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static IEnumerable<MaxDepenetrationVelocityRigidbodyTween> TweensMaxDepenetrationVelocity(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MaxDepenetrationVelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxDepenetrationVelocity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPosition(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPosition(this IEnumerable<Rigidbody> self, Vector3 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPosition(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPositionX(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPositionX(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionX(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPositionY(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPositionY(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionY(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPositionZ(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPositionZ(this IEnumerable<Rigidbody> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionZ(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RotationRigidbodyTween TweenRotation(this Rigidbody self, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationRigidbodyTween, Rigidbody, Quaternion>(options, optionsMode);
        }

        public static IEnumerable<RotationRigidbodyTween> TweensRotation(this IEnumerable<Rigidbody> self, Quaternion options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RotationRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRotation(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseGravityRigidbodyTween TweenUseGravity(this Rigidbody self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseGravityRigidbodyTween, Rigidbody, bool>(options, optionsMode);
        }

        public static IEnumerable<UseGravityRigidbodyTween> TweensUseGravity(this IEnumerable<Rigidbody> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseGravityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseGravity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VelocityRigidbodyTween TweenVelocity(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VelocityRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static IEnumerable<VelocityRigidbodyTween> TweensVelocity(this IEnumerable<Rigidbody> self, Vector3 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<VelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVelocity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}