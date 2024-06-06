using System.Collections.Generic;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class ProjectorExtensions
    {
        public static AspectRatioProjectorTween TweenAspectRatio(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<AspectRatioProjectorTween, Projector, float>(options, optionsMode);
        }

        public static IEnumerable<AspectRatioProjectorTween> TweensAspectRatio(this IEnumerable<Projector> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AspectRatioProjectorTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAspectRatio(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FarClipPlaneProjectorTween TweenFarClipPlane(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FarClipPlaneProjectorTween, Projector, float>(options, optionsMode);
        }

        public static IEnumerable<FarClipPlaneProjectorTween> TweensFarClipPlane(this IEnumerable<Projector> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FarClipPlaneProjectorTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFarClipPlane(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FOVProjectorTween TweenFOV(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FOVProjectorTween, Projector, float>(options, optionsMode);
        }

        public static IEnumerable<FOVProjectorTween> TweensFOV(this IEnumerable<Projector> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FOVProjectorTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFOV(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NearClipPlaneProjectorTween TweenNearClipPlane(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<NearClipPlaneProjectorTween, Projector, float>(options, optionsMode);
        }

        public static IEnumerable<NearClipPlaneProjectorTween> TweensNearClipPlane(this IEnumerable<Projector> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NearClipPlaneProjectorTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNearClipPlane(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OrthographicProjectorTween TweenOrthographic(this Projector self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicProjectorTween, Projector, bool>(options, optionsMode);
        }

        public static IEnumerable<OrthographicProjectorTween> TweensOrthographic(this IEnumerable<Projector> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<OrthographicProjectorTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrthographic(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static OrthographicSizeProjectorTween TweenOrthographicSize(this Projector self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<OrthographicSizeProjectorTween, Projector, float>(options, optionsMode);
        }

        public static IEnumerable<OrthographicSizeProjectorTween> TweensOrthographicSize(this IEnumerable<Projector> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<OrthographicSizeProjectorTween>();
            foreach (var target in self)
            {
                var tween = target.TweenOrthographicSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}