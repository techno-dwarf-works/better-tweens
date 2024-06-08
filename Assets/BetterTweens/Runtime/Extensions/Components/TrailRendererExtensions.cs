using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TrailRendererExtensions
    {
        public static AutodestructTrailRendererTween TweenAutodestruct(this TrailRenderer self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<AutodestructTrailRendererTween, TrailRenderer, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<AutodestructTrailRendererTween> TweensAutodestruct(this IEnumerable<TrailRenderer> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<AutodestructTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenAutodestruct(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EmittingTrailRendererTween TweenEmitting(this TrailRenderer self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EmittingTrailRendererTween, TrailRenderer, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<EmittingTrailRendererTween> TweensEmitting(this IEnumerable<TrailRenderer> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EmittingTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEmitting(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndColorTrailRendererTween TweenEndColor(this TrailRenderer self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndColorTrailRendererTween, TrailRenderer, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<EndColorTrailRendererTween> TweensEndColor(this IEnumerable<TrailRenderer> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndColorTrailRendererTween TweenEndColor(this TrailRenderer self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EndColorTrailRendererTween, TrailRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<EndColorTrailRendererTween> TweensEndColor(this IEnumerable<TrailRenderer> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndWidthTrailRendererTween TweenEndWidth(this TrailRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndWidthTrailRendererTween, TrailRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<EndWidthTrailRendererTween> TweensEndWidth(this IEnumerable<TrailRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndWidthTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndWidth(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MinVertexDistanceTrailRendererTween TweenMinVertexDistance(this TrailRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinVertexDistanceTrailRendererTween, TrailRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<MinVertexDistanceTrailRendererTween> TweensMinVertexDistance(this IEnumerable<TrailRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MinVertexDistanceTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMinVertexDistance(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NumCapVerticesTrailRendererTween TweenNumCapVertices(this TrailRenderer self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCapVerticesTrailRendererTween, TrailRenderer, int>(duration, options, optionsMode);
        }

        public static IEnumerable<NumCapVerticesTrailRendererTween> TweensNumCapVertices(this IEnumerable<TrailRenderer> self, float duration, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NumCapVerticesTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNumCapVertices(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NumCornerVerticesTrailRendererTween TweenNumCornerVertices(this TrailRenderer self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCornerVerticesTrailRendererTween, TrailRenderer, int>(duration, options, optionsMode);
        }

        public static IEnumerable<NumCornerVerticesTrailRendererTween> TweensNumCornerVertices(this IEnumerable<TrailRenderer> self, float duration, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NumCornerVerticesTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNumCornerVertices(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowBiasTrailRendererTween TweenShadowBias(this TrailRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasTrailRendererTween, TrailRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowBiasTrailRendererTween> TweensShadowBias(this IEnumerable<TrailRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowBiasTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowBias(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartColorTrailRendererTween TweenStartColor(this TrailRenderer self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartColorTrailRendererTween, TrailRenderer, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<StartColorTrailRendererTween> TweensStartColor(this IEnumerable<TrailRenderer> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartColorTrailRendererTween TweenStartColor(this TrailRenderer self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<StartColorTrailRendererTween, TrailRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<StartColorTrailRendererTween> TweensStartColor(this IEnumerable<TrailRenderer> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartColorTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartWidthTrailRendererTween TweenStartWidth(this TrailRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartWidthTrailRendererTween, TrailRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<StartWidthTrailRendererTween> TweensStartWidth(this IEnumerable<TrailRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartWidthTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartWidth(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static TimeTrailRendererTween TweenTime(this TrailRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeTrailRendererTween, TrailRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<TimeTrailRendererTween> TweensTime(this IEnumerable<TrailRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<TimeTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenTime(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WidthMultiplierTrailRendererTween TweenWidthMultiplier(this TrailRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WidthMultiplierTrailRendererTween, TrailRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<WidthMultiplierTrailRendererTween> TweensWidthMultiplier(this IEnumerable<TrailRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WidthMultiplierTrailRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWidthMultiplier(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}