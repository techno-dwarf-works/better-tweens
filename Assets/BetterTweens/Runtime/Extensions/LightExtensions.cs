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

        public static BoundingSphereLightTween TweenBoundingSphere(this Light self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<BoundingSphereLightTween, Light, Vector4>(options, optionsMode);
        }

        public static ColorLightTween TweenColor(this Light self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorLightTween, Light, Color, ColorOptions>(options, optionsMode);
        }

        public static ColorLightTween TweenColor(this Light self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<ColorLightTween, Light>(options, optionsMode);
        }

        public static ColorTemperatureLightTween TweenColorTemperature(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ColorTemperatureLightTween, Light, float>(options, optionsMode);
        }

        public static CookieSizeLightTween TweenCookieSize(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<CookieSizeLightTween, Light, float>(options, optionsMode);
        }

        public static InnerSpotAngleLightTween TweenInnerSpotAngle(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<InnerSpotAngleLightTween, Light, float>(options, optionsMode);
        }

        public static IntensityLightTween TweenIntensity(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<IntensityLightTween, Light, float>(options, optionsMode);
        }

        public static RangeLightTween TweenRange(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<RangeLightTween, Light, float>(options, optionsMode);
        }

        public static ShadowAngleLightTween TweenShadowAngle(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowAngleLightTween, Light, float>(options, optionsMode);
        }

        public static ShadowBiasLightTween TweenShadowBias(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowBiasLightTween, Light, float>(options, optionsMode);
        }

        public static ShadowCustomResolutionLightTween TweenShadowCustomResolution(this Light self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowCustomResolutionLightTween, Light, int>(options, optionsMode);
        }

        public static ShadowNearPlaneLightTween TweenShadowNearPlane(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowNearPlaneLightTween, Light, float>(options, optionsMode);
        }

        public static ShadowNormalBiasLightTween TweenShadowNormalBias(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowNormalBiasLightTween, Light, float>(options, optionsMode);
        }

        public static ShadowRadiusLightTween TweenShadowRadius(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowRadiusLightTween, Light, float>(options, optionsMode);
        }

        public static ShadowStrengthLightTween TweenShadowStrength(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<ShadowStrengthLightTween, Light, float>(options, optionsMode);
        }

        public static SpotAngleLightTween TweenSpotAngle(this Light self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<SpotAngleLightTween, Light, float>(options, optionsMode);
        }

        public static UseBoundingSphereLightTween TweenUseBoundingSphere(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseBoundingSphereLightTween, Light, bool>(options, optionsMode);
        }

        public static UseColorTemperatureLightTween TweenUseColorTemperature(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseColorTemperatureLightTween, Light, bool>(options, optionsMode);
        }

        public static UseFrustumShadowCasterLightTween TweenUseFrustumShadowCaster(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseFrustumShadowCasterLightTween, Light, bool>(options, optionsMode);
        }

        public static UseShadowMatrixLightTween TweenUseShadowMatrix(this Light self, bool options, OptionsMode optionsMode = default)
        {
            return self.Tween<UseShadowMatrixLightTween, Light, bool>(options, optionsMode);
        }
    }
}