using System;
using System.Text;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Triggers.ValueOptions;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class ColorTween : Tween<Color, ColorOptions>
    {
        [SerializeField] private bool _ignoreAlpha;

        public bool IgnoreAlpha => _ignoreAlpha;

        public ColorTween SetIgnoreAlpha(bool ignored = true)
        {
            _ignoreAlpha = ignored;
            return this;
        }

        protected override Color CalculateRelativeFrom(Color to, ColorOptions options)
        {
            return to - options.Color;
        }

        protected override Color CalculateTo(Color from, ColorOptions options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options.Color,
                OptionsMode.Relative => from + options.Color,
                OptionsMode.Speed => from + options.Color * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override ColorOptions GetRelativeOptions(Color from, Color to)
        {
            var color = to - from;
            return new CustomColorOptions(color);
        }

        protected sealed override void EvaluateState(Color fromValue, Color toValue, float time)
        {
            var value = Color.Lerp(fromValue, toValue, time);
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(Color value);

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendFieldLine(nameof(IgnoreAlpha), IgnoreAlpha);
        }
    }

    [Serializable]
    public abstract class ColorTween<TTarget> : TargetTween<TTarget, Color, ColorOptions>
        where TTarget : class
    {
        [SerializeField] private bool _ignoreAlpha;

        public bool IgnoreAlpha => _ignoreAlpha;

        public ColorTween<TTarget> SetIgnoreAlpha(bool ignored = true)
        {
            _ignoreAlpha = ignored;
            return this;
        }

        protected override Color CalculateRelativeFrom(Color to, ColorOptions options)
        {
            return to - options.Color;
        }

        protected override Color CalculateTo(Color from, ColorOptions options, OptionsMode optionsMode)
        {
            return optionsMode switch
            {
                OptionsMode.To => options.Color,
                OptionsMode.Relative => from + options.Color,
                OptionsMode.Speed => from + options.Color * Duration,
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };
        }

        protected override ColorOptions GetRelativeOptions(Color from, Color to)
        {
            var color = to - from;
            return new CustomColorOptions(color);
        }

        protected sealed override void EvaluateState(Color fromValue, Color toValue, float time)
        {
            var value = Color.Lerp(fromValue, toValue, time);
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(Color value);

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendFieldLine(nameof(IgnoreAlpha), IgnoreAlpha);
        }
    }
}