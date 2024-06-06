using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TrailRendererExtensions
    {
        public static AutodestructTrailRendererTween TweenAutodestruct(this TrailRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<AutodestructTrailRendererTween, TrailRenderer, bool>(options, optionsMode);
        }

        public static IEnumerable<AutodestructTrailRendererTween> TweensAutodestruct(this IEnumerable<TrailRenderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AutodestructTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAutodestruct(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EmittingTrailRendererTween TweenEmitting(this TrailRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EmittingTrailRendererTween, TrailRenderer, bool>(options, optionsMode);
        }

        public static IEnumerable<EmittingTrailRendererTween> TweensEmitting(this IEnumerable<TrailRenderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EmittingTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEmitting(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndColorTrailRendererTween TweenEndColor(this TrailRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndColorTrailRendererTween, TrailRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<EndColorTrailRendererTween> TweensEndColor(this IEnumerable<TrailRenderer> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndColorTrailRendererTween TweenEndColor(this TrailRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EndColorTrailRendererTween, TrailRenderer>(options, optionsMode);
        }

        public static IEnumerable<EndColorTrailRendererTween> TweensEndColor(this IEnumerable<TrailRenderer> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndWidthTrailRendererTween TweenEndWidth(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndWidthTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static IEnumerable<EndWidthTrailRendererTween> TweensEndWidth(this IEnumerable<TrailRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndWidthTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndWidth(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MinVertexDistanceTrailRendererTween TweenMinVertexDistance(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinVertexDistanceTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static IEnumerable<MinVertexDistanceTrailRendererTween> TweensMinVertexDistance(this IEnumerable<TrailRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MinVertexDistanceTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMinVertexDistance(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NumCapVerticesTrailRendererTween TweenNumCapVertices(this TrailRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCapVerticesTrailRendererTween, TrailRenderer, int>(options, optionsMode);
        }

        public static IEnumerable<NumCapVerticesTrailRendererTween> TweensNumCapVertices(this IEnumerable<TrailRenderer> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NumCapVerticesTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNumCapVertices(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NumCornerVerticesTrailRendererTween TweenNumCornerVertices(this TrailRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCornerVerticesTrailRendererTween, TrailRenderer, int>(options, optionsMode);
        }

        public static IEnumerable<NumCornerVerticesTrailRendererTween> TweensNumCornerVertices(this IEnumerable<TrailRenderer> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NumCornerVerticesTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNumCornerVertices(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowBiasTrailRendererTween TweenShadowBias(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowBiasTrailRendererTween> TweensShadowBias(this IEnumerable<TrailRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowBiasTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowBias(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartColorTrailRendererTween TweenStartColor(this TrailRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartColorTrailRendererTween, TrailRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<StartColorTrailRendererTween> TweensStartColor(this IEnumerable<TrailRenderer> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartColorTrailRendererTween TweenStartColor(this TrailRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<StartColorTrailRendererTween, TrailRenderer>(options, optionsMode);
        }

        public static IEnumerable<StartColorTrailRendererTween> TweensStartColor(this IEnumerable<TrailRenderer> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartWidthTrailRendererTween TweenStartWidth(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartWidthTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static IEnumerable<StartWidthTrailRendererTween> TweensStartWidth(this IEnumerable<TrailRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartWidthTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartWidth(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TimeTrailRendererTween TweenTime(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static IEnumerable<TimeTrailRendererTween> TweensTime(this IEnumerable<TrailRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<TimeTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTime(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WidthMultiplierTrailRendererTween TweenWidthMultiplier(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WidthMultiplierTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static IEnumerable<WidthMultiplierTrailRendererTween> TweensWidthMultiplier(this IEnumerable<TrailRenderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WidthMultiplierTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWidthMultiplier(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}