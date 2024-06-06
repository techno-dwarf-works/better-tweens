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

        public static ColorPropertyBlockRendererTween TweenColorPropertyBlock(this Renderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorPropertyBlockRendererTween, Renderer>(options, optionsMode);
        }

        public static DynamicOcclusionRendererTween TweenDynamicOcclusion(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<DynamicOcclusionRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static EnabledRendererTween TweenEnabled(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EnabledRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static FloatPropertyBlockRendererTween TweenFloatPropertyBlock(this Renderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<FloatPropertyBlockRendererTween, Renderer, float>(options, optionsMode);
        }

        public static ForceRenderingOffRendererTween TweenForceRenderingOff(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ForceRenderingOffRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static IntegerPropertyBlockRendererTween TweenIntegerPropertyBlock(this Renderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<IntegerPropertyBlockRendererTween, Renderer, int>(options, optionsMode);
        }

        public static PriorityRendererTween TweenPriority(this Renderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PriorityRendererTween, Renderer, int>(options, optionsMode);
        }

        public static ReceiveShadowsRendererTween TweenReceiveShadows(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<ReceiveShadowsRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static SortingOrderRendererTween TweenSortingOrder(this Renderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<SortingOrderRendererTween, Renderer, int>(options, optionsMode);
        }

        public static StaticShadowCasterRendererTween TweenStaticShadowCaster(this Renderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<StaticShadowCasterRendererTween, Renderer, bool>(options, optionsMode);
        }

        public static VectorPropertyBlockRendererTween TweenVectorPropertyBlock(this Renderer self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<VectorPropertyBlockRendererTween, Renderer, Vector4>(options, optionsMode);
        }
    }
}