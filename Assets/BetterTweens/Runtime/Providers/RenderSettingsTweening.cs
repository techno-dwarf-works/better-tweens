using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class RenderSettingsTweening
    {
        public static AmbientEquatorColorRenderSettingsTween TweenAmbientEquatorColor(float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new AmbientEquatorColorRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static AmbientGroundColorRenderSettingsTween TweenAmbientGroundColor(float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new AmbientGroundColorRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static AmbientIntensityRenderSettingsTween TweenAmbientIntensity(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new AmbientIntensityRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static AmbientLightRenderSettingsTween TweenAmbientLight(float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new AmbientLightRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static AmbientSkyColorRenderSettingsTween TweenAmbientSkyColor(float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new AmbientSkyColorRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FlareFadeSpeedRenderSettingsTween TweenFlareFadeSpeed(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new FlareFadeSpeedRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FlareStrengthRenderSettingsTween TweenFlareStrength(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new FlareStrengthRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FogColorRenderSettingsTween TweenFogColor(float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new FogColorRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FogDensityRenderSettingsTween TweenFogDensity(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new FogDensityRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FogEndDistanceRenderSettingsTween TweenFogEndDistance(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new FogEndDistanceRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FogRenderSettingsTween TweenFog(float duration, bool options, OptionsMode optionsMode = default)
        {
            var tween = new FogRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static FogStartDistanceRenderSettingsTween TweenFogStartDistance(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new FogStartDistanceRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static HaloStrengthRenderSettingsTween TweenHaloStrength(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new HaloStrengthRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static ReflectionBouncesRenderSettingsTween TweenReflectionBounces(float duration, int options, OptionsMode optionsMode = default)
        {
            var tween = new ReflectionBouncesRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static ReflectionIntensityRenderSettingsTween TweenReflectionIntensity(float duration, float options, OptionsMode optionsMode = default)
        {
            var tween = new ReflectionIntensityRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static ReflectionResolutionRenderSettingsTween TweenReflectionResolution(float duration, int options, OptionsMode optionsMode = default)
        {
            var tween = new ReflectionResolutionRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }

        public static SubtractiveShadowColorRenderSettingsTween TweenSubtractiveShadowColor(float duration, Color options, OptionsMode optionsMode = default)
        {
            var tween = new SubtractiveShadowColorRenderSettingsTween();
            tween.SetOptions(options)
                .SetOptionsMode(optionsMode)
                .SetDuration(duration);

            return tween;
        }
    }
}