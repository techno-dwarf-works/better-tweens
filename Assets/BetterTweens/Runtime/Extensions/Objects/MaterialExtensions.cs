using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class MaterialExtensions
    {
        public static MainColorMaterialTween TweenMainColor(this Material self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainColorMaterialTween, Material, Color, ColorOptions>(options, optionsMode);
        }

        public static MainColorMaterialTween TweenMainColor(this Material self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<MainColorMaterialTween, Material>(options, optionsMode);
        }

        public static MainTextureOffsetMaterialTween TweenMainTextureOffset(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainTextureOffsetMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static MainTextureScaleMaterialTween TweenMainTextureScale(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainTextureScaleMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static PropertyColorMaterialTween TweenPropertyColor(this Material self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyColorMaterialTween, Material, Color, ColorOptions>(options, optionsMode);
        }

        public static PropertyColorMaterialTween TweenPropertyColor(this Material self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<PropertyColorMaterialTween, Material>(options, optionsMode);
        }

        public static PropertyFloatMaterialTween TweenPropertyFloat(this Material self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyFloatMaterialTween, Material, float>(options, optionsMode);
        }

        public static PropertyIntegerMaterialTween TweenPropertyInteger(this Material self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyIntegerMaterialTween, Material, int>(options, optionsMode);
        }

        public static PropertyTextureOffsetMaterialTween TweenPropertyTextureOffset(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyTextureOffsetMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static PropertyTextureScaleMaterialTween TweenPropertyTextureScale(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyTextureScaleMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static PropertyVectorMaterialTween TweenPropertyVector(this Material self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyVectorMaterialTween, Material, Vector4>(options, optionsMode);
        }
    }
}