using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LightExtensions
    {
        public static BounceIntensityLightTween TweenBounceIntensity(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BounceIntensityLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<BounceIntensityLightTween> TweensBounceIntensity(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BounceIntensityLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBounceIntensity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BoundingSphereLightTween TweenBoundingSphere(this Light self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<BoundingSphereLightTween, Light, Vector4>(options, optionsMode);
        }

        public static IEnumerable<BoundingSphereLightTween> TweensBoundingSphere(this IEnumerable<Light> self, Vector4 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<BoundingSphereLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBoundingSphere(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLightTween TweenColor(this Light self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorLightTween, Light, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<ColorLightTween> TweensColor(this IEnumerable<Light> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLightTween TweenColor(this Light self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorLightTween, Light>(options, optionsMode);
        }

        public static IEnumerable<ColorLightTween> TweensColor(this IEnumerable<Light> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorTemperatureLightTween TweenColorTemperature(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorTemperatureLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ColorTemperatureLightTween> TweensColorTemperature(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ColorTemperatureLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColorTemperature(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CookieSizeLightTween TweenCookieSize(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<CookieSizeLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<CookieSizeLightTween> TweensCookieSize(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<CookieSizeLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCookieSize(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InnerSpotAngleLightTween TweenInnerSpotAngle(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<InnerSpotAngleLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<InnerSpotAngleLightTween> TweensInnerSpotAngle(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<InnerSpotAngleLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInnerSpotAngle(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IntensityLightTween TweenIntensity(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<IntensityLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<IntensityLightTween> TweensIntensity(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<IntensityLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIntensity(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RangeLightTween TweenRange(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RangeLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<RangeLightTween> TweensRange(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<RangeLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRange(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowAngleLightTween TweenShadowAngle(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowAngleLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowAngleLightTween> TweensShadowAngle(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowAngleLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowAngle(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowBiasLightTween TweenShadowBias(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowBiasLightTween> TweensShadowBias(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowBiasLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowBias(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowCustomResolutionLightTween TweenShadowCustomResolution(this Light self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowCustomResolutionLightTween, Light, int>(options, optionsMode);
        }

        public static IEnumerable<ShadowCustomResolutionLightTween> TweensShadowCustomResolution(this IEnumerable<Light> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowCustomResolutionLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowCustomResolution(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowNearPlaneLightTween TweenShadowNearPlane(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowNearPlaneLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowNearPlaneLightTween> TweensShadowNearPlane(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowNearPlaneLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowNearPlane(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowNormalBiasLightTween TweenShadowNormalBias(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowNormalBiasLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowNormalBiasLightTween> TweensShadowNormalBias(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowNormalBiasLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowNormalBias(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowRadiusLightTween TweenShadowRadius(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowRadiusLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowRadiusLightTween> TweensShadowRadius(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowRadiusLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowRadius(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowStrengthLightTween TweenShadowStrength(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowStrengthLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<ShadowStrengthLightTween> TweensShadowStrength(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<ShadowStrengthLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowStrength(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpotAngleLightTween TweenSpotAngle(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpotAngleLightTween, Light, float>(options, optionsMode);
        }

        public static IEnumerable<SpotAngleLightTween> TweensSpotAngle(this IEnumerable<Light> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<SpotAngleLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpotAngle(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseBoundingSphereLightTween TweenUseBoundingSphere(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseBoundingSphereLightTween, Light, bool>(options, optionsMode);
        }

        public static IEnumerable<UseBoundingSphereLightTween> TweensUseBoundingSphere(this IEnumerable<Light> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseBoundingSphereLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseBoundingSphere(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseColorTemperatureLightTween TweenUseColorTemperature(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseColorTemperatureLightTween, Light, bool>(options, optionsMode);
        }

        public static IEnumerable<UseColorTemperatureLightTween> TweensUseColorTemperature(this IEnumerable<Light> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseColorTemperatureLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseColorTemperature(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseFrustumShadowCasterLightTween TweenUseFrustumShadowCaster(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseFrustumShadowCasterLightTween, Light, bool>(options, optionsMode);
        }

        public static IEnumerable<UseFrustumShadowCasterLightTween> TweensUseFrustumShadowCaster(this IEnumerable<Light> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseFrustumShadowCasterLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseFrustumShadowCaster(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseShadowMatrixLightTween TweenUseShadowMatrix(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseShadowMatrixLightTween, Light, bool>(options, optionsMode);
        }

        public static IEnumerable<UseShadowMatrixLightTween> TweensUseShadowMatrix(this IEnumerable<Light> self, bool options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<UseShadowMatrixLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseShadowMatrix(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}