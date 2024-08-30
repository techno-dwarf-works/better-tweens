using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class CameraExtensions
    {
        public static AspectCameraTween TweenAspect(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<AspectCameraTween> TweensAspect(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<AspectCameraTween>();
            }

            var tweens = new List<AspectCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAspect(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BackgroundColorCameraTween TweenBackgroundColor(this Camera self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<BackgroundColorCameraTween, Camera, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<BackgroundColorCameraTween> TweensBackgroundColor(this IEnumerable<Camera> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BackgroundColorCameraTween>();
            }

            var tweens = new List<BackgroundColorCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBackgroundColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BackgroundColorCameraTween TweenBackgroundColor(this Camera self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<BackgroundColorCameraTween, Camera>(duration, options, optionsMode);
        }

        public static IEnumerable<BackgroundColorCameraTween> TweensBackgroundColor(this IEnumerable<Camera> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BackgroundColorCameraTween>();
            }

            var tweens = new List<BackgroundColorCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBackgroundColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DepthCameraTween TweenDepth(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DepthCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<DepthCameraTween> TweensDepth(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<DepthCameraTween>();
            }

            var tweens = new List<DepthCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDepth(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FarClipPlaneCameraTween TweenFarClipPlane(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FarClipPlaneCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FarClipPlaneCameraTween> TweensFarClipPlane(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FarClipPlaneCameraTween>();
            }

            var tweens = new List<FarClipPlaneCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFarClipPlane(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FocalLengthCameraTween TweenFocalLength(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FocalLengthCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FocalLengthCameraTween> TweensFocalLength(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FocalLengthCameraTween>();
            }

            var tweens = new List<FocalLengthCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFocalLength(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FOVCameraTween TweenFOV(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FOVCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<FOVCameraTween> TweensFOV(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<FOVCameraTween>();
            }

            var tweens = new List<FOVCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFOV(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LensShiftCameraTween TweenLensShift(this Camera self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LensShiftCameraTween, Camera, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<LensShiftCameraTween> TweensLensShift(this IEnumerable<Camera> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<LensShiftCameraTween>();
            }

            var tweens = new List<LensShiftCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLensShift(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NearClipPlaneCameraTween TweenNearClipPlane(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NearClipPlaneCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<NearClipPlaneCameraTween> TweensNearClipPlane(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<NearClipPlaneCameraTween>();
            }

            var tweens = new List<NearClipPlaneCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNearClipPlane(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OrthographicCameraTween TweenOrthographic(this Camera self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicCameraTween, Camera, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<OrthographicCameraTween> TweensOrthographic(this IEnumerable<Camera> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<OrthographicCameraTween>();
            }

            var tweens = new List<OrthographicCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrthographic(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OrthographicSizeCameraTween TweenOrthographicSize(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicSizeCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<OrthographicSizeCameraTween> TweensOrthographicSize(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<OrthographicSizeCameraTween>();
            }

            var tweens = new List<OrthographicSizeCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrthographicSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SensorSizeCameraTween TweenSensorSize(this Camera self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SensorSizeCameraTween, Camera, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<SensorSizeCameraTween> TweensSensorSize(this IEnumerable<Camera> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<SensorSizeCameraTween>();
            }

            var tweens = new List<SensorSizeCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSensorSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StereoConvergenceCameraTween TweenStereoConvergence(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StereoConvergenceCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<StereoConvergenceCameraTween> TweensStereoConvergence(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<StereoConvergenceCameraTween>();
            }

            var tweens = new List<StereoConvergenceCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStereoConvergence(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StereoSeparationCameraTween TweenStereoSeparation(this Camera self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StereoSeparationCameraTween, Camera, float>(duration, options, optionsMode);
        }

        public static IEnumerable<StereoSeparationCameraTween> TweensStereoSeparation(this IEnumerable<Camera> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<StereoSeparationCameraTween>();
            }

            var tweens = new List<StereoSeparationCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStereoSeparation(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TargetDisplayCameraTween TweenTargetDisplay(this Camera self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<TargetDisplayCameraTween, Camera, int>(duration, options, optionsMode);
        }

        public static IEnumerable<TargetDisplayCameraTween> TweensTargetDisplay(this IEnumerable<Camera> self, float duration, int options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<TargetDisplayCameraTween>();
            }

            var tweens = new List<TargetDisplayCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTargetDisplay(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}