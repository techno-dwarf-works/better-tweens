using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class RendererExtensions
    {
        public static ColorPropertyBlockRendererTween TweenColorPropertyBlock(this Renderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorPropertyBlockRendererTween, Renderer, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<ColorPropertyBlockRendererTween> TweensColorPropertyBlock(this IEnumerable<Renderer> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorPropertyBlockRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColorPropertyBlock(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorPropertyBlockRendererTween TweenColorPropertyBlock(this Renderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorPropertyBlockRendererTween, Renderer>(options, optionsMode);
        }

        public static IEnumerable<ColorPropertyBlockRendererTween> TweensColorPropertyBlock(this IEnumerable<Renderer> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorPropertyBlockRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColorPropertyBlock(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static DynamicOcclusionRendererTween TweenDynamicOcclusion(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<DynamicOcclusionRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static IEnumerable<DynamicOcclusionRendererTween> TweensDynamicOcclusion(this IEnumerable<Renderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<DynamicOcclusionRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenDynamicOcclusion(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static EnabledRendererTween TweenEnabled(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EnabledRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static IEnumerable<EnabledRendererTween> TweensEnabled(this IEnumerable<Renderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<EnabledRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenEnabled(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static FloatPropertyBlockRendererTween TweenFloatPropertyBlock(this Renderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FloatPropertyBlockRendererTween, Renderer, float>(options, optionsMode);
        }

        public static IEnumerable<FloatPropertyBlockRendererTween> TweensFloatPropertyBlock(this IEnumerable<Renderer> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<FloatPropertyBlockRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenFloatPropertyBlock(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ForceRenderingOffRendererTween TweenForceRenderingOff(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ForceRenderingOffRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static IEnumerable<ForceRenderingOffRendererTween> TweensForceRenderingOff(this IEnumerable<Renderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ForceRenderingOffRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenForceRenderingOff(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IntegerPropertyBlockRendererTween TweenIntegerPropertyBlock(this Renderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<IntegerPropertyBlockRendererTween, Renderer, int>(options, optionsMode);
        }

        public static IEnumerable<IntegerPropertyBlockRendererTween> TweensIntegerPropertyBlock(this IEnumerable<Renderer> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<IntegerPropertyBlockRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIntegerPropertyBlock(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PriorityRendererTween TweenPriority(this Renderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityRendererTween, Renderer, int>(options, optionsMode);
        }

        public static IEnumerable<PriorityRendererTween> TweensPriority(this IEnumerable<Renderer> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PriorityRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPriority(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ReceiveShadowsRendererTween TweenReceiveShadows(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReceiveShadowsRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static IEnumerable<ReceiveShadowsRendererTween> TweensReceiveShadows(this IEnumerable<Renderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ReceiveShadowsRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenReceiveShadows(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SortingOrderRendererTween TweenSortingOrder(this Renderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<SortingOrderRendererTween, Renderer, int>(options, optionsMode);
        }

        public static IEnumerable<SortingOrderRendererTween> TweensSortingOrder(this IEnumerable<Renderer> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SortingOrderRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSortingOrder(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static StaticShadowCasterRendererTween TweenStaticShadowCaster(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<StaticShadowCasterRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static IEnumerable<StaticShadowCasterRendererTween> TweensStaticShadowCaster(this IEnumerable<Renderer> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<StaticShadowCasterRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenStaticShadowCaster(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static VectorPropertyBlockRendererTween TweenVectorPropertyBlock(this Renderer self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VectorPropertyBlockRendererTween, Renderer, Vector4>(options, optionsMode);
        }

        public static IEnumerable<VectorPropertyBlockRendererTween> TweensVectorPropertyBlock(this IEnumerable<Renderer> self, Vector4 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<VectorPropertyBlockRendererTween>();
            foreach (var target in self)
            {
                var tween = target.TweenVectorPropertyBlock(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}