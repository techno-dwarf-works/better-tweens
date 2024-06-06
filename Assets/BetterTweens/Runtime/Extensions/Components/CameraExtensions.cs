using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class CameraExtensions
    {
        public static AspectCameraTween TweenAspect(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<AspectCameraTween> TweensAspect(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AspectCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAspect(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BackgroundColorCameraTween TweenBackgroundColor(this Camera self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<BackgroundColorCameraTween, Camera, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<BackgroundColorCameraTween> TweensBackgroundColor(this IEnumerable<Camera> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BackgroundColorCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBackgroundColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BackgroundColorCameraTween TweenBackgroundColor(this Camera self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<BackgroundColorCameraTween, Camera>(options, optionsMode);
        }

        public static IEnumerable<BackgroundColorCameraTween> TweensBackgroundColor(this IEnumerable<Camera> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BackgroundColorCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBackgroundColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DepthCameraTween TweenDepth(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DepthCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<DepthCameraTween> TweensDepth(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DepthCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDepth(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FarClipPlaneCameraTween TweenFarClipPlane(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FarClipPlaneCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<FarClipPlaneCameraTween> TweensFarClipPlane(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FarClipPlaneCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFarClipPlane(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FocalLengthCameraTween TweenFocalLength(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FocalLengthCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<FocalLengthCameraTween> TweensFocalLength(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FocalLengthCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFocalLength(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FOVCameraTween TweenFOV(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FOVCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<FOVCameraTween> TweensFOV(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FOVCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFOV(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LensShiftCameraTween TweenLensShift(this Camera self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LensShiftCameraTween, Camera, Vector2>(options, optionsMode);
        }

        public static IEnumerable<LensShiftCameraTween> TweensLensShift(this IEnumerable<Camera> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<LensShiftCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLensShift(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NearClipPlaneCameraTween TweenNearClipPlane(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NearClipPlaneCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<NearClipPlaneCameraTween> TweensNearClipPlane(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NearClipPlaneCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNearClipPlane(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OrthographicCameraTween TweenOrthographic(this Camera self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicCameraTween, Camera, bool>(options, optionsMode);
        }

        public static IEnumerable<OrthographicCameraTween> TweensOrthographic(this IEnumerable<Camera> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<OrthographicCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrthographic(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OrthographicSizeCameraTween TweenOrthographicSize(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicSizeCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<OrthographicSizeCameraTween> TweensOrthographicSize(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<OrthographicSizeCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrthographicSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SensorSizeCameraTween TweenSensorSize(this Camera self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SensorSizeCameraTween, Camera, Vector2>(options, optionsMode);
        }

        public static IEnumerable<SensorSizeCameraTween> TweensSensorSize(this IEnumerable<Camera> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SensorSizeCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSensorSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StereoConvergenceCameraTween TweenStereoConvergence(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StereoConvergenceCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<StereoConvergenceCameraTween> TweensStereoConvergence(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StereoConvergenceCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStereoConvergence(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StereoSeparationCameraTween TweenStereoSeparation(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StereoSeparationCameraTween, Camera, float>(options, optionsMode);
        }

        public static IEnumerable<StereoSeparationCameraTween> TweensStereoSeparation(this IEnumerable<Camera> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StereoSeparationCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStereoSeparation(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TargetDisplayCameraTween TweenTargetDisplay(this Camera self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<TargetDisplayCameraTween, Camera, int>(options, optionsMode);
        }

        public static IEnumerable<TargetDisplayCameraTween> TweensTargetDisplay(this IEnumerable<Camera> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<TargetDisplayCameraTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTargetDisplay(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}