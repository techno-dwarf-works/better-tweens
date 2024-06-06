using System.Collections.Generic;
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

        public static IEnumerable<MainColorMaterialTween> TweensTweenMainColor(this IEnumerable<Material> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MainColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MainColorMaterialTween TweenMainColor(this Material self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<MainColorMaterialTween, Material>(options, optionsMode);
        }

        public static IEnumerable<MainColorMaterialTween> TweensTweenMainColor(this IEnumerable<Material> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MainColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MainTextureOffsetMaterialTween TweenMainTextureOffset(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainTextureOffsetMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static IEnumerable<MainTextureOffsetMaterialTween> TweensTweenMainTextureOffset(this IEnumerable<Material> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MainTextureOffsetMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainTextureOffset(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MainTextureScaleMaterialTween TweenMainTextureScale(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainTextureScaleMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static IEnumerable<MainTextureScaleMaterialTween> TweensTweenMainTextureScale(this IEnumerable<Material> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<MainTextureScaleMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainTextureScale(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyColorMaterialTween TweenPropertyColor(this Material self, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyColorMaterialTween, Material, Color, ColorOptions>(options, optionsMode);
        }

        public static IEnumerable<PropertyColorMaterialTween> TweensTweenPropertyColor(this IEnumerable<Material> self, ColorOptions options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyColorMaterialTween TweenPropertyColor(this Material self, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<PropertyColorMaterialTween, Material>(options, optionsMode);
        }

        public static IEnumerable<PropertyColorMaterialTween> TweensTweenPropertyColor(this IEnumerable<Material> self, Color options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyColor(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyFloatMaterialTween TweenPropertyFloat(this Material self, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyFloatMaterialTween, Material, float>(options, optionsMode);
        }

        public static IEnumerable<PropertyFloatMaterialTween> TweensTweenPropertyFloat(this IEnumerable<Material> self, float options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyFloatMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyFloat(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyIntegerMaterialTween TweenPropertyInteger(this Material self, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyIntegerMaterialTween, Material, int>(options, optionsMode);
        }

        public static IEnumerable<PropertyIntegerMaterialTween> TweensTweenPropertyInteger(this IEnumerable<Material> self, int options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyIntegerMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyInteger(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyTextureOffsetMaterialTween TweenPropertyTextureOffset(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyTextureOffsetMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static IEnumerable<PropertyTextureOffsetMaterialTween> TweensTweenPropertyTextureOffset(this IEnumerable<Material> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyTextureOffsetMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyTextureOffset(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyTextureScaleMaterialTween TweenPropertyTextureScale(this Material self, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyTextureScaleMaterialTween, Material, Vector2>(options, optionsMode);
        }

        public static IEnumerable<PropertyTextureScaleMaterialTween> TweensTweenPropertyTextureScale(this IEnumerable<Material> self, Vector2 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyTextureScaleMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyTextureScale(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyVectorMaterialTween TweenPropertyVector(this Material self, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyVectorMaterialTween, Material, Vector4>(options, optionsMode);
        }

        public static IEnumerable<PropertyVectorMaterialTween> TweensTweenPropertyVector(this IEnumerable<Material> self, Vector4 options, OptionsMode optionsMode = default)
        {
            // TODO: Add self validation

            var tweens = new List<PropertyVectorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyVector(options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}