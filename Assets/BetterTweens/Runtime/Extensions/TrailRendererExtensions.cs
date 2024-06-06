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

        public static EmittingTrailRendererTween TweenEmitting(this TrailRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<EmittingTrailRendererTween, TrailRenderer, bool>(options, optionsMode);
        }

        public static EndColorTrailRendererTween TweenEndColor(this TrailRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndColorTrailRendererTween, TrailRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static EndColorTrailRendererTween TweenEndColor(this TrailRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EndColorTrailRendererTween, TrailRenderer>(options, optionsMode);
        }

        public static EndWidthTrailRendererTween TweenEndWidth(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndWidthTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static MinVertexDistanceTrailRendererTween TweenMinVertexDistance(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<MinVertexDistanceTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static NumCapVerticesTrailRendererTween TweenNumCapVertices(this TrailRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCapVerticesTrailRendererTween, TrailRenderer, int>(options, optionsMode);
        }

        public static NumCornerVerticesTrailRendererTween TweenNumCornerVertices(this TrailRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCornerVerticesTrailRendererTween, TrailRenderer, int>(options, optionsMode);
        }

        public static ShadowBiasTrailRendererTween TweenShadowBias(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static StartColorTrailRendererTween TweenStartColor(this TrailRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartColorTrailRendererTween, TrailRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static StartColorTrailRendererTween TweenStartColor(this TrailRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<StartColorTrailRendererTween, TrailRenderer>(options, optionsMode);
        }

        public static StartWidthTrailRendererTween TweenStartWidth(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartWidthTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static TimeTrailRendererTween TweenTime(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<TimeTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }

        public static WidthMultiplierTrailRendererTween TweenWidthMultiplier(this TrailRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WidthMultiplierTrailRendererTween, TrailRenderer, float>(options, optionsMode);
        }
    }
}