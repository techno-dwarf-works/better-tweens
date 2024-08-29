using System;
using System.Collections.Generic;
using Better.Commons.Runtime.Enums;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TransformExtensions
    {
        #region Direction

        public static UpTransformTween TweenUp(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<UpTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<UpTransformTween> TweensUp(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UpTransformTween>();
            }
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UpTransformTween>();
            }
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UpTransformTween>();
            }

            var tweens = new List<UpTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUp(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ForwardTransformTween TweenForward(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<ForwardTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<ForwardTransformTween> TweensForward(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ForwardTransformTween>();
            }

            var tweens = new List<ForwardTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenForward(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RightTransformTween TweenRight(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<RightTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<RightTransformTween> TweensRight(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<RightTransformTween>();
            }

            var tweens = new List<RightTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRight(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion

        #region Position

        public static PositionTransformTween TweenPosition(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<PositionTransformTween> TweensPosition(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionTransformTween>();
            }

            var tweens = new List<PositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionTransformTween TweenPositionX(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.Y)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<PositionTransformTween> TweensPositionX(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionTransformTween>();
            }

            var tweens = new List<PositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionTransformTween TweenPositionY(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<PositionTransformTween> TweensPositionY(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionTransformTween>();
            }

            var tweens = new List<PositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionTransformTween TweenPositionZ(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<PositionTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Y);

            return tween;
        }

        public static IEnumerable<PositionTransformTween> TweensPositionZ(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<PositionTransformTween>();
            }

            var tweens = new List<PositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionZ(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion

        #region LocalPosition

        public static LocalPositionTransformTween TweenLocalPosition(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalPositionTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<LocalPositionTransformTween> TweensLocalPosition(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalPositionTransformTween>();
            }

            var tweens = new List<LocalPositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalPosition(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalPositionTransformTween TweenLocalPositionX(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalPositionTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.Y)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<LocalPositionTransformTween> TweensLocalPositionX(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalPositionTransformTween>();
            }

            var tweens = new List<LocalPositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalPositionX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalPositionTransformTween TweenLocalPositionY(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalPositionTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<LocalPositionTransformTween> TweensLocalPositionY(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalPositionTransformTween>();
            }

            var tweens = new List<LocalPositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalPositionY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalPositionTransformTween TweenLocalPositionZ(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalPositionTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Y);

            return tween;
        }

        public static IEnumerable<LocalPositionTransformTween> TweensLocalPositionZ(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalPositionTransformTween>();
            }

            var tweens = new List<LocalPositionTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalPositionZ(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion

        #region Rotation

        public static EulerAnglesTransformTween TweenEulerAngles(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<EulerAnglesTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<EulerAnglesTransformTween> TweensEulerAngles(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<EulerAnglesTransformTween>();
            }

            var tweens = new List<EulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEulerAngles(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EulerAnglesTransformTween TweenEulerAngleX(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<EulerAnglesTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.Y)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<EulerAnglesTransformTween> TweensEulerAngleX(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<EulerAnglesTransformTween>();
            }

            var tweens = new List<EulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEulerAngleX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EulerAnglesTransformTween TweenEulerAngleY(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<EulerAnglesTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<EulerAnglesTransformTween> TweensEulerAngleY(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<EulerAnglesTransformTween>();
            }

            var tweens = new List<EulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEulerAngleY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EulerAnglesTransformTween TweenEulerAngleZ(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<EulerAnglesTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Y);

            return tween;
        }

        public static IEnumerable<EulerAnglesTransformTween> TweensEulerAngleZ(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<EulerAnglesTransformTween>();
            }

            var tweens = new List<EulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEulerAngleZ(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RotationTransformTween TweenRotation(this Transform self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<RotationTransformTween, Transform, Quaternion>(duration, options, optionsMode);
        }

        public static IEnumerable<RotationTransformTween> TweensRotation(this IEnumerable<Transform> self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<RotationTransformTween>();
            }

            var tweens = new List<RotationTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRotation(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion

        #region LocalRotation

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngles(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalEulerAnglesTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<LocalEulerAnglesTransformTween> TweensLocalEulerAngles(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalEulerAnglesTransformTween>();
            }

            var tweens = new List<LocalEulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalEulerAngles(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngleX(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalEulerAnglesTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.Y)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<LocalEulerAnglesTransformTween> TweensLocalEulerAngleX(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalEulerAnglesTransformTween>();
            }

            var tweens = new List<LocalEulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalEulerAngleX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngleY(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalEulerAnglesTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<LocalEulerAnglesTransformTween> TweensLocalEulerAngleY(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalEulerAnglesTransformTween>();
            }

            var tweens = new List<LocalEulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalEulerAngleY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalEulerAnglesTransformTween TweenLocalEulerAngleZ(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalEulerAnglesTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Y);

            return tween;
        }

        public static IEnumerable<LocalEulerAnglesTransformTween> TweensLocalEulerAngleZ(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalEulerAnglesTransformTween>();
            }

            var tweens = new List<LocalEulerAnglesTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalEulerAngleZ(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalRotationTransformTween TweenLocalRotation(this Transform self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalRotationTransformTween, Transform, Quaternion>(duration, options, optionsMode);
        }

        public static IEnumerable<LocalRotationTransformTween> TweensLocalRotation(this IEnumerable<Transform> self, float duration, Quaternion options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalRotationTransformTween>();
            }

            var tweens = new List<LocalRotationTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalRotation(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion

        #region LocalScale

        public static LocalScaleTransformTween TweenLocalScale(this Transform self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LocalScaleTransformTween, Transform, Vector3>(duration, options, optionsMode);
        }

        public static IEnumerable<LocalScaleTransformTween> TweensLocalScale(this IEnumerable<Transform> self, float duration, Vector3 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalScaleTransformTween>();
            }

            var tweens = new List<LocalScaleTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalScale(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalScaleTransformTween TweenLocalScale(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.TweenVector3<LocalScaleTransformTween, Transform>(duration, options, optionsMode);
        }

        public static IEnumerable<LocalScaleTransformTween> TweensLocalScale(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalScaleTransformTween>();
            }

            var tweens = new List<LocalScaleTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalScale(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalScaleTransformTween TweenLocalScaleX(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalScaleTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.Y)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<LocalScaleTransformTween> TweensLocalScaleX(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalScaleTransformTween>();
            }

            var tweens = new List<LocalScaleTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalScaleX(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalScaleTransformTween TweenLocalScaleY(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalScaleTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Z);

            return tween;
        }

        public static IEnumerable<LocalScaleTransformTween> TweensLocalScaleY(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalScaleTransformTween>();
            }

            var tweens = new List<LocalScaleTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalScaleY(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LocalScaleTransformTween TweenLocalScaleZ(this Transform self, float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = self.TweenVector3<LocalScaleTransformTween, Transform>(duration, options, optionsMode);
            tween.AddConstraint(Vector3Axis.X)
                .AddConstraint(Vector3Axis.Y);

            return tween;
        }

        public static IEnumerable<LocalScaleTransformTween> TweensLocalScaleZ(this IEnumerable<Transform> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LocalScaleTransformTween>();
            }

            var tweens = new List<LocalScaleTransformTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLocalScaleZ(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        #endregion
    }
}