using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class MaterialExtensions
    {
        public static MainColorMaterialTween TweenMainColor(this Material self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainColorMaterialTween, Material, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<MainColorMaterialTween> TweensTweenMainColor(this IEnumerable<Material> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MainColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MainColorMaterialTween TweenMainColor(this Material self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<MainColorMaterialTween, Material>(duration, options, optionsMode);
        }

        public static IEnumerable<MainColorMaterialTween> TweensTweenMainColor(this IEnumerable<Material> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MainColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MainTextureOffsetMaterialTween TweenMainTextureOffset(this Material self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainTextureOffsetMaterialTween, Material, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<MainTextureOffsetMaterialTween> TweensTweenMainTextureOffset(this IEnumerable<Material> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MainTextureOffsetMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainTextureOffset(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static MainTextureScaleMaterialTween TweenMainTextureScale(this Material self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<MainTextureScaleMaterialTween, Material, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<MainTextureScaleMaterialTween> TweensTweenMainTextureScale(this IEnumerable<Material> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<MainTextureScaleMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenMainTextureScale(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyColorMaterialTween TweenPropertyColor(this Material self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyColorMaterialTween, Material, Color, ColorOptions>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyColorMaterialTween> TweensTweenPropertyColor(this IEnumerable<Material> self, float duration, ColorOptions options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyColorMaterialTween TweenPropertyColor(this Material self, float duration, Color options, OptionsMode optionsMode = default)
        {
            return self.TweenColor<PropertyColorMaterialTween, Material>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyColorMaterialTween> TweensTweenPropertyColor(this IEnumerable<Material> self, float duration, Color options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyColorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyColor(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyFloatMaterialTween TweenPropertyFloat(this Material self, float duration, float options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyFloatMaterialTween, Material, float>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyFloatMaterialTween> TweensTweenPropertyFloat(this IEnumerable<Material> self, float duration, float options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyFloatMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyFloat(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyIntegerMaterialTween TweenPropertyInteger(this Material self, float duration, int options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyIntegerMaterialTween, Material, int>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyIntegerMaterialTween> TweensTweenPropertyInteger(this IEnumerable<Material> self, float duration, int options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyIntegerMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyInteger(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyTextureOffsetMaterialTween TweenPropertyTextureOffset(this Material self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyTextureOffsetMaterialTween, Material, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyTextureOffsetMaterialTween> TweensTweenPropertyTextureOffset(this IEnumerable<Material> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyTextureOffsetMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyTextureOffset(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyTextureScaleMaterialTween TweenPropertyTextureScale(this Material self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyTextureScaleMaterialTween, Material, Vector2>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyTextureScaleMaterialTween> TweensTweenPropertyTextureScale(this IEnumerable<Material> self, float duration, Vector2 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyTextureScaleMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyTextureScale(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }

        public static PropertyVectorMaterialTween TweenPropertyVector(this Material self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            return self.Tween<PropertyVectorMaterialTween, Material, Vector4>(duration, options, optionsMode);
        }

        public static IEnumerable<PropertyVectorMaterialTween> TweensTweenPropertyVector(this IEnumerable<Material> self, float duration, Vector4 options, OptionsMode optionsMode = default)
        {
            

            var tweens = new List<PropertyVectorMaterialTween>();
            foreach (var target in self)
            {
                var tween = target.TweenPropertyVector(duration, options, optionsMode);
                tweens.Add(tween);
            }

            return tweens;
        }
    }
}