﻿using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LineRendererExtensions
    {
        public static EndColorLineRendererTween TweenEndColor(this LineRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndColorLineRendererTween, LineRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static EndColorLineRendererTween TweenEndColor(this LineRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<EndColorLineRendererTween, LineRenderer>(options, optionsMode);
        }

        public static EndWidthLineRendererTween TweenEndWidth(this LineRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<EndWidthLineRendererTween, LineRenderer, float>(options, optionsMode);
        }

        public static LoopLineRendererTween TweenLoop(this LineRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<LoopLineRendererTween, LineRenderer, bool>(options, optionsMode);
        }

        public static NumCapVerticesLineRendererTween TweenNumCapVertices(this LineRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCapVerticesLineRendererTween, LineRenderer, int>(options, optionsMode);
        }

        public static NumCornerVerticesLineRendererTween TweenNumCornerVertices(this LineRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<NumCornerVerticesLineRendererTween, LineRenderer, int>(options, optionsMode);
        }

        public static PositionCountLineRendererTween TweenPositionCount(this LineRenderer self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PositionCountLineRendererTween, LineRenderer, int>(options, optionsMode);
        }

        public static ShadowBiasLineRendererTween TweenShadowBias(this LineRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasLineRendererTween, LineRenderer, float>(options, optionsMode);
        }

        public static StartColorLineRendererTween TweenStartColor(this LineRenderer self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartColorLineRendererTween, LineRenderer, Color, ColorOptions>(options, optionsMode);
        }

        public static StartColorLineRendererTween TweenStartColor(this LineRenderer self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<StartColorLineRendererTween, LineRenderer>(options, optionsMode);
        }

        public static StartWidthLineRendererTween TweenStartWidth(this LineRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<StartWidthLineRendererTween, LineRenderer, float>(options, optionsMode);
        }

        public static WidthMultiplierLineRendererTween TweenWidthMultiplier(this LineRenderer self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<WidthMultiplierLineRendererTween, LineRenderer, float>(options, optionsMode);
        }

        public static WorldSpaceLineRendererTween TweenWorldSpace(this LineRenderer self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<WorldSpaceLineRendererTween, LineRenderer, bool>(options, optionsMode);
        }
    }
}