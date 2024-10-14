using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LightExtensions
    {
        public static BounceIntensityLightTween TweenBounceIntensity(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<BounceIntensityLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<BounceIntensityLightTween> TweensBounceIntensity(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BounceIntensityLightTween>();
            }

            var tweens = new List<BounceIntensityLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBounceIntensity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static BoundingSphereLightTween TweenBoundingSphere(this Light self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<BoundingSphereLightTween, Light, Vector4>(duration, options, optionsMode);
        }

        public static IEnumerable<BoundingSphereLightTween> TweensBoundingSphere(this IEnumerable<Light> self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<BoundingSphereLightTween>();
            }

            var tweens = new List<BoundingSphereLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenBoundingSphere(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLightTween TweenColor(this Light self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorLightTween, Light, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorLightTween> TweensColor(this IEnumerable<Light> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorLightTween>();
            }

            var tweens = new List<ColorLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorLightTween TweenColor(this Light self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorLightTween, Light>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorLightTween> TweensColor(this IEnumerable<Light> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorLightTween>();
            }

            var tweens = new List<ColorLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ColorTemperatureLightTween TweenColorTemperature(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorTemperatureLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ColorTemperatureLightTween> TweensColorTemperature(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ColorTemperatureLightTween>();
            }

            var tweens = new List<ColorTemperatureLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenColorTemperature(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static CookieSizeLightTween TweenCookieSize(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<CookieSizeLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<CookieSizeLightTween> TweensCookieSize(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<CookieSizeLightTween>();
            }

            var tweens = new List<CookieSizeLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenCookieSize(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static InnerSpotAngleLightTween TweenInnerSpotAngle(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<InnerSpotAngleLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<InnerSpotAngleLightTween> TweensInnerSpotAngle(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<InnerSpotAngleLightTween>();
            }

            var tweens = new List<InnerSpotAngleLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenInnerSpotAngle(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static IntensityLightTween TweenIntensity(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<IntensityLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<IntensityLightTween> TweensIntensity(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<IntensityLightTween>();
            }

            var tweens = new List<IntensityLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenIntensity(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static RangeLightTween TweenRange(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RangeLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<RangeLightTween> TweensRange(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<RangeLightTween>();
            }

            var tweens = new List<RangeLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenRange(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowBiasLightTween TweenShadowBias(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowBiasLightTween> TweensShadowBias(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ShadowBiasLightTween>();
            }

            var tweens = new List<ShadowBiasLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowBias(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowCustomResolutionLightTween TweenShadowCustomResolution(this Light self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowCustomResolutionLightTween, Light, int>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowCustomResolutionLightTween> TweensShadowCustomResolution(this IEnumerable<Light> self, float duration, int options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ShadowCustomResolutionLightTween>();
            }

            var tweens = new List<ShadowCustomResolutionLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowCustomResolution(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowNearPlaneLightTween TweenShadowNearPlane(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowNearPlaneLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowNearPlaneLightTween> TweensShadowNearPlane(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ShadowNearPlaneLightTween>();
            }

            var tweens = new List<ShadowNearPlaneLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowNearPlane(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowNormalBiasLightTween TweenShadowNormalBias(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowNormalBiasLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowNormalBiasLightTween> TweensShadowNormalBias(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ShadowNormalBiasLightTween>();
            }

            var tweens = new List<ShadowNormalBiasLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowNormalBias(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static ShadowStrengthLightTween TweenShadowStrength(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowStrengthLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<ShadowStrengthLightTween> TweensShadowStrength(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<ShadowStrengthLightTween>();
            }

            var tweens = new List<ShadowStrengthLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenShadowStrength(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static SpotAngleLightTween TweenSpotAngle(this Light self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpotAngleLightTween, Light, float>(duration, options, optionsMode);
        }

        public static IEnumerable<SpotAngleLightTween> TweensSpotAngle(this IEnumerable<Light> self, float duration, float options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<SpotAngleLightTween>();
            }

            var tweens = new List<SpotAngleLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenSpotAngle(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseBoundingSphereLightTween TweenUseBoundingSphere(this Light self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseBoundingSphereLightTween, Light, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<UseBoundingSphereLightTween> TweensUseBoundingSphere(this IEnumerable<Light> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UseBoundingSphereLightTween>();
            }

            var tweens = new List<UseBoundingSphereLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseBoundingSphere(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseColorTemperatureLightTween TweenUseColorTemperature(this Light self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseColorTemperatureLightTween, Light, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<UseColorTemperatureLightTween> TweensUseColorTemperature(this IEnumerable<Light> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UseColorTemperatureLightTween>();
            }

            var tweens = new List<UseColorTemperatureLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseColorTemperature(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseFrustumShadowCasterLightTween TweenUseFrustumShadowCaster(this Light self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseFrustumShadowCasterLightTween, Light, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<UseFrustumShadowCasterLightTween> TweensUseFrustumShadowCaster(this IEnumerable<Light> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UseFrustumShadowCasterLightTween>();
            }

            var tweens = new List<UseFrustumShadowCasterLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseFrustumShadowCaster(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static UseShadowMatrixLightTween TweenUseShadowMatrix(this Light self, float duration, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseShadowMatrixLightTween, Light, bool>(duration, options, optionsMode);
        }

        public static IEnumerable<UseShadowMatrixLightTween> TweensUseShadowMatrix(this IEnumerable<Light> self, float duration, bool options, OptionsMode optionsMode = default)
        {
            if (!ValidationUtility.ValidateNullReference(self))
            {
                return Array.Empty<UseShadowMatrixLightTween>();
            }

            var tweens = new List<UseShadowMatrixLightTween>();
            foreach (var target in self)
            {
                var tween = target.TweenUseShadowMatrix(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}