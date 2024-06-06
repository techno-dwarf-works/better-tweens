using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LineRendererExtensions
    {
        public static EndColorLineRendererTween TweenEndColor(this LineRenderer self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndColorLineRendererTween, LineRenderer, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<EndColorLineRendererTween> TweensEndColor(this IEnumerable<LineRenderer> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndColorLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndColorLineRendererTween TweenEndColor(this LineRenderer self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EndColorLineRendererTween, LineRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<EndColorLineRendererTween> TweensEndColor(this IEnumerable<LineRenderer> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndColorLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EndWidthLineRendererTween TweenEndWidth(this LineRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndWidthLineRendererTween, LineRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<EndWidthLineRendererTween> TweensEndWidth(this IEnumerable<LineRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EndWidthLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEndWidth(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static LoopLineRendererTween TweenLoop(this LineRenderer self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<LoopLineRendererTween, LineRenderer, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<LoopLineRendererTween> TweensLoop(this IEnumerable<LineRenderer> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<LoopLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenLoop(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NumCapVerticesLineRendererTween TweenNumCapVertices(this LineRenderer self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCapVerticesLineRendererTween, LineRenderer, int>(duration, options, optionsMode);
        }

        public static IEnumerable<NumCapVerticesLineRendererTween> TweensNumCapVertices(this IEnumerable<LineRenderer> self, float duration, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NumCapVerticesLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNumCapVertices(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static NumCornerVerticesLineRendererTween TweenNumCornerVertices(this LineRenderer self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCornerVerticesLineRendererTween, LineRenderer, int>(duration, options, optionsMode);
        }

        public static IEnumerable<NumCornerVerticesLineRendererTween> TweensNumCornerVertices(this IEnumerable<LineRenderer> self, float duration, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<NumCornerVerticesLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenNumCornerVertices(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PositionCountLineRendererTween TweenPositionCount(this LineRenderer self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionCountLineRendererTween, LineRenderer, int>(duration, options, optionsMode);
        }

        public static IEnumerable<PositionCountLineRendererTween> TweensPositionCount(this IEnumerable<LineRenderer> self, float duration, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PositionCountLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPositionCount(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowBiasLineRendererTween TweenShadowBias(this LineRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasLineRendererTween, LineRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowBiasLineRendererTween> TweensShadowBias(this IEnumerable<LineRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowBiasLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowBias(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartColorLineRendererTween TweenStartColor(this LineRenderer self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartColorLineRendererTween, LineRenderer, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<StartColorLineRendererTween> TweensStartColor(this IEnumerable<LineRenderer> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartColorLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartColorLineRendererTween TweenStartColor(this LineRenderer self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<StartColorLineRendererTween, LineRenderer>(duration, options, optionsMode);
        }

        public static IEnumerable<StartColorLineRendererTween> TweensStartColor(this IEnumerable<LineRenderer> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartColorLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StartWidthLineRendererTween TweenStartWidth(this LineRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartWidthLineRendererTween, LineRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<StartWidthLineRendererTween> TweensStartWidth(this IEnumerable<LineRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StartWidthLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStartWidth(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WidthMultiplierLineRendererTween TweenWidthMultiplier(this LineRenderer self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WidthMultiplierLineRendererTween, LineRenderer, float>(duration, options, optionsMode);
        }

        public static IEnumerable<WidthMultiplierLineRendererTween> TweensWidthMultiplier(this IEnumerable<LineRenderer> self, float duration, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WidthMultiplierLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWidthMultiplier(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static WorldSpaceLineRendererTween TweenWorldSpace(this LineRenderer self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<WorldSpaceLineRendererTween, LineRenderer, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<WorldSpaceLineRendererTween> TweensWorldSpace(this IEnumerable<LineRenderer> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<WorldSpaceLineRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenWorldSpace(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}