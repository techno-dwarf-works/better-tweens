using Better.Tweens.Runtime.BetterTweens.Runtime.Enums;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TransformExtensions
    {
        #region Direction

        public static UpTransformTween TweenUp(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<UpTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static ForwardTransformTween TweenForward(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<ForwardTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static RightTransformTween TweenRight(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<RightTransformTween, Transform, Vector3>(options, optionsMode);
        }

        #endregion

        #region Position

        public static PositionTransformTween TweenPosition(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static PositionTransformTween TweenPositionX(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static PositionTransformTween TweenPositionY(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static PositionTransformTween TweenPositionZ(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        #endregion

        #region LocalPosition

        public static LocalPositionTransformTween TweenLocalPosition(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalPositionTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static LocalPositionTransformTween TweenLocalPositionX(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalPositionTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static LocalPositionTransformTween TweenLocalPositionY(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalPositionTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static LocalPositionTransformTween TweenLocalPositionZ(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalPositionTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        #endregion

        #region Rotation

        public static EulerAnglesTransformTween TweenEulerAngles(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<EulerAnglesTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static EulerAnglesTransformTween TweenEulerAngleX(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<EulerAnglesTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static EulerAnglesTransformTween TweenEulerAngleY(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<EulerAnglesTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static EulerAnglesTransformTween TweenEulerAngleZ(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<EulerAnglesTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        public static RotationTransformTween TweenRotation(this Transform self, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationTransformTween, Transform, Quaternion>(options, optionsMode);
        }

        #endregion

        #region LocalRotation

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngles(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalEulerAnglesTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngleX(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalEulerAnglesTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngleY(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalEulerAnglesTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngleZ(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalEulerAnglesTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        public static LocalRotationTransformTween TweenLocalRotation(this Transform self, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalRotationTransformTween, Transform, Quaternion>(options, optionsMode);
        }

        #endregion

        #region LocalScale

        public static LocalScaleTransformTween TweenLocalScale(this Transform self, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalScaleTransformTween, Transform, Vector3>(options, optionsMode);
        }

        public static LocalScaleTransformTween TweenLocalScale(this Transform self, float options, OptionsMode optionsMode = default)
        {
            return self.TweenLocalScale(options, optionsMode);
        }

        public static LocalScaleTransformTween TweenLocalScaleX(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalScaleTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.Y)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static LocalScaleTransformTween TweenLocalScaleY(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalScaleTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Z);

            return tween;
        }

        public static LocalScaleTransformTween TweenLocalScaleZ(this Transform self, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalScaleTransformTween, Transform>(options, optionsMode);
            tween.AddConstraint(XYZAxis.X)
                .AddConstraint(XYZAxis.Y);

            return tween;
        }

        #endregion
    }
}