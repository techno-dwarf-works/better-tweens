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

        public static AngularVelocityRigidbodyTween TweenAngularVelocity(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<AngularVelocityRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static CenterOfMassRigidbodyTween TweenCenterOfMass(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<CenterOfMassRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static DragRigidbodyTween TweenDrag(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DragRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static InertiaTensorRigidbodyTween TweenInertiaTensor(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaTensorRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static InertiaTensorRotationRigidbodyTween TweenInertiaTensorRotation(this Rigidbody self, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<InertiaTensorRotationRigidbodyTween, Rigidbody, Quaternion>(options, optionsMode);
        }

        public static KinematicRigidbodyTween TweenKinematic(this Rigidbody self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<KinematicRigidbodyTween, Rigidbody, bool>(options, optionsMode);
        }

        public static MassRigidbodyTween TweenMass(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MassRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static MaxAngularVelocityRigidbodyTween TweenMaxAngularVelocity(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxAngularVelocityRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static MaxDepenetrationVelocityRigidbodyTween TweenMaxDepenetrationVelocity(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MaxDepenetrationVelocityRigidbodyTween, Rigidbody, float>(options, optionsMode);
        }

        public static PositionRigidbodyTween TweenPosition(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }

        public static PositionRigidbodyTween TweenPositionX(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static PositionRigidbodyTween TweenPositionY(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static PositionRigidbodyTween TweenPositionZ(this Rigidbody self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionRigidbodyTween, Rigidbody>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        public static RotationRigidbodyTween TweenRotation(this Rigidbody self, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationRigidbodyTween, Rigidbody, Quaternion>(options, optionsMode);
        }

        public static UseGravityRigidbodyTween TweenUseGravity(this Rigidbody self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseGravityRigidbodyTween, Rigidbody, bool>(options, optionsMode);
        }

        public static VelocityRigidbodyTween TweenVelocity(this Rigidbody self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VelocityRigidbodyTween, Rigidbody, Vector3>(options, optionsMode);
        }
    }
}