using System;
using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TargetTweenExtensions
    {
        internal static TTween Tween<TTween, TTarget, TValue, TValueOptions>(this TTarget self, TValueOptions options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, TValue, TValueOptions>, new()
            where TTarget : class
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return null;
            }

            var tween = new TTween();
            tween.SetTarget(self)
                .SetOptions(options)
                .SetOptionsMode(optionsMode);

            return tween;
        }

        internal static TTween Tween<TTween, TTarget, TValue>(this TTarget self, TValue options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, TValue>, new()
            where TTarget : class
        {
            return self.Tween<TTween, TTarget, TValue, TValue>(options, optionsMode);
        }

        internal static TTween Tween<TTween, TTarget>(this TTarget self, TTarget options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget>, new()
            where TTarget : class
        {
            return self.Tween<TTween, TTarget, TTarget, TTarget>(options, optionsMode);
        }

        internal static TTween TweenColor<TTween, TTarget>(this TTarget self, Color options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, Color, ColorOptions>, new()
            where TTarget : class
        {
            var colorOptions = new CustomColorOptions(options);
            return self.Tween<TTween, TTarget, Color, ColorOptions>(colorOptions, optionsMode);
        }

        internal static TTween TweenVector2<TTween, TTarget>(this TTarget self, float options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, Vector2>, new()
            where TTarget : class
        {
            var vectorOptions = Vector2.one * options;
            return self.Tween<TTween, TTarget, Vector2>(vectorOptions, optionsMode);
        }

        internal static TTween TweenVector2Int<TTween, TTarget>(this TTarget self, int options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, Vector2Int>, new()
            where TTarget : class
        {
            var vectorOptions = Vector2Int.one * options;
            return self.Tween<TTween, TTarget, Vector2Int>(vectorOptions, optionsMode);
        }

        internal static TTween TweenVector3<TTween, TTarget>(this TTarget self, float options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, Vector3>, new()
            where TTarget : class
        {
            var vectorOptions = Vector3.one * options;
            return self.Tween<TTween, TTarget, Vector3>(vectorOptions, optionsMode);
        }

        internal static TTween TweenVector3Int<TTween, TTarget>(this TTarget self, int options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, Vector3Int>, new()
            where TTarget : class
        {
            var vectorOptions = Vector3Int.one * options;
            return self.Tween<TTween, TTarget, Vector3Int>(vectorOptions, optionsMode);
        }

        internal static TTween TweenVector4<TTween, TTarget>(this TTarget self, float options, OptionsMode optionsMode)
            where TTween : TargetTween<TTarget, Vector4>, new()
            where TTarget : class
        {
            var vectorOptions = Vector4.one * options;
            return self.Tween<TTween, TTarget, Vector4>(vectorOptions, optionsMode);
        }
    }
}