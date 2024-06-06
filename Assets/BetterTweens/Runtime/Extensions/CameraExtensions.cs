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

        public static BackgroundColorCameraTween TweenBackgroundColor(this Camera self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<BackgroundColorCameraTween, Camera, Color, ColorOptions>(options, optionsMode);
        }

        public static BackgroundColorCameraTween TweenBackgroundColor(this Camera self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<BackgroundColorCameraTween, Camera>(options, optionsMode);
        }

        public static DepthCameraTween TweenDepth(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<DepthCameraTween, Camera, float>(options, optionsMode);
        }

        public static FarClipPlaneCameraTween TweenFarClipPlane(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FarClipPlaneCameraTween, Camera, float>(options, optionsMode);
        }

        public static FocalLengthCameraTween TweenFocalLength(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FocalLengthCameraTween, Camera, float>(options, optionsMode);
        }

        public static FOVCameraTween TweenFOV(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FOVCameraTween, Camera, float>(options, optionsMode);
        }

        public static LensShiftCameraTween TweenLensShift(this Camera self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<LensShiftCameraTween, Camera, Vector2>(options, optionsMode);
        }

        public static NearClipPlaneCameraTween TweenNearClipPlane(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NearClipPlaneCameraTween, Camera, float>(options, optionsMode);
        }

        public static OrthographicCameraTween TweenOrthographic(this Camera self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicCameraTween, Camera, bool>(options, optionsMode);
        }

        public static OrthographicSizeCameraTween TweenOrthographicSize(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicSizeCameraTween, Camera, float>(options, optionsMode);
        }

        public static SensorSizeCameraTween TweenSensorSize(this Camera self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<SensorSizeCameraTween, Camera, Vector2>(options, optionsMode);
        }

        public static StereoConvergenceCameraTween TweenStereoConvergence(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StereoConvergenceCameraTween, Camera, float>(options, optionsMode);
        }

        public static StereoSeparationCameraTween TweenStereoSeparation(this Camera self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StereoSeparationCameraTween, Camera, float>(options, optionsMode);
        }

        public static TargetDisplayCameraTween TweenTargetDisplay(this Camera self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<TargetDisplayCameraTween, Camera, int>(options, optionsMode);
        }
    }
}