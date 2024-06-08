using System.Collections.Generic;
using Better.Commons.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class RigidbodyExtensions
    {
        public static AngularDragRigidbodyTween TweenAngularDrag(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularDragRigidbodyTween, Rigidbody, float>(duration, options, optionsMode);
        }

        public static IEnumerable<AngularDragRigidbodyTween> TweensAngularDrag(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AngularDragRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAngularDrag(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static AngularVelocityRigidbodyTween TweenAngularVelocity(this Rigidbody self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularVelocityRigidbodyTween, Rigidbody, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<AngularVelocityRigidbodyTween> TweensAngularVelocity(this IEnumerable<Rigidbody> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<AngularVelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAngularVelocity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CenterOfMassRigidbodyTween TweenCenterOfMass(this Rigidbody self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<CenterOfMassRigidbodyTween, Rigidbody, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<CenterOfMassRigidbodyTween> TweensCenterOfMass(this IEnumerable<Rigidbody> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<CenterOfMassRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCenterOfMass(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DragRigidbodyTween TweenDrag(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DragRigidbodyTween, Rigidbody, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DragRigidbodyTween> TweensDrag(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<DragRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDrag(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InertiaTensorRigidbodyTween TweenInertiaTensor(this Rigidbody self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaTensorRigidbodyTween, Rigidbody, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<InertiaTensorRigidbodyTween> TweensInertiaTensor(this IEnumerable<Rigidbody> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<InertiaTensorRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInertiaTensor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InertiaTensorRotationRigidbodyTween TweenInertiaTensorRotation(this Rigidbody self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaTensorRotationRigidbodyTween, Rigidbody, Quaternion>(duration, options, optionsMode);
        }

        public static IEnumerable<InertiaTensorRotationRigidbodyTween> TweensInertiaTensorRotation(this IEnumerable<Rigidbody> self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<InertiaTensorRotationRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInertiaTensorRotation(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static KinematicRigidbodyTween TweenKinematic(this Rigidbody self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<KinematicRigidbodyTween, Rigidbody, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<KinematicRigidbodyTween> TweensKinematic(this IEnumerable<Rigidbody> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<KinematicRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenKinematic(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MassRigidbodyTween TweenMass(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MassRigidbodyTween, Rigidbody, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MassRigidbodyTween> TweensMass(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MassRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMass(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxAngularVelocityRigidbodyTween TweenMaxAngularVelocity(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxAngularVelocityRigidbodyTween, Rigidbody, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MaxAngularVelocityRigidbodyTween> TweensMaxAngularVelocity(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MaxAngularVelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxAngularVelocity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MaxDepenetrationVelocityRigidbodyTween TweenMaxDepenetrationVelocity(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDepenetrationVelocityRigidbodyTween, Rigidbody, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MaxDepenetrationVelocityRigidbodyTween> TweensMaxDepenetrationVelocity(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MaxDepenetrationVelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMaxDepenetrationVelocity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPosition(this Rigidbody self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionRigidbodyTween, Rigidbody, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPosition(this IEnumerable<Rigidbody> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPositionX(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.Y)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPositionX(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPositionY(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPositionY(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionRigidbodyTween TweenPositionZ(this Rigidbody self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Y);

            return tween;
        }

        public static IEnumerable<PositionRigidbodyTween> TweensPositionZ(this IEnumerable<Rigidbody> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PositionRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionZ(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RotationRigidbodyTween TweenRotation(this Rigidbody self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationRigidbodyTween, Rigidbody, Quaternion>(duration, options, optionsMode);
        }

        public static IEnumerable<RotationRigidbodyTween> TweensRotation(this IEnumerable<Rigidbody> self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<RotationRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRotation(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseGravityRigidbodyTween TweenUseGravity(this Rigidbody self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseGravityRigidbodyTween, Rigidbody, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<UseGravityRigidbodyTween> TweensUseGravity(this IEnumerable<Rigidbody> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<UseGravityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseGravity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VelocityRigidbodyTween TweenVelocity(this Rigidbody self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VelocityRigidbodyTween, Rigidbody, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<VelocityRigidbodyTween> TweensVelocity(this IEnumerable<Rigidbody> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<VelocityRigidbodyTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVelocity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}