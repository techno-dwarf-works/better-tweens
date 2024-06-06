using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class ProjectorExtensions
    {
        public static AspectRatioProjectorTween TweenAspectRatio(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectRatioProjectorTween, Projector, float>(options, optionsMode);
        }

        public static FarClipPlaneProjectorTween TweenFarClipPlane(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FarClipPlaneProjectorTween, Projector, float>(options, optionsMode);
        }

        public static FOVProjectorTween TweenFOV(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FOVProjectorTween, Projector, float>(options, optionsMode);
        }

        public static NearClipPlaneProjectorTween TweenNearClipPlane(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NearClipPlaneProjectorTween, Projector, float>(options, optionsMode);
        }

        public static OrthographicProjectorTween TweenOrthographic(this Projector self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicProjectorTween, Projector, bool>(options, optionsMode);
        }

        public static OrthographicSizeProjectorTween TweenOrthographicSize(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicSizeProjectorTween, Projector, float>(options, optionsMode);
        }
    }
}