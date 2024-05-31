using System;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class BoolTween : Tween<bool>
    {
        protected override bool CalculateRelativeFrom(bool to, bool options)
        {
            return to ^ options;
        }

        protected override bool CalculateTo(bool from, bool options, OptionsMode optionsMode)
        {
            switch (optionsMode)
            {
                case OptionsMode.To:
                case OptionsMode.Speed:
                    return options;
                case OptionsMode.Relative:
                    return from ^ options;
                default:
                    throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null);
            }
        }

        protected override bool GetRelativeOptions(bool from, bool to)
        {
            return from ^ to;
        }

        protected sealed override void EvaluateState(bool fromValue, bool toValue, float time)
        {
            var value = time < 0.5f ? fromValue : toValue;
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(bool value);
    }

    [Serializable]
    public abstract class BoolTween<TTarget> : TargetTween<TTarget, bool>
        where TTarget : class
    {
        protected override bool CalculateRelativeFrom(bool to, bool options)
        {
            return to ^ options;
        }

        protected override bool CalculateTo(bool from, bool options, OptionsMode optionsMode)
        {
            switch (optionsMode)
            {
                case OptionsMode.To:
                case OptionsMode.Speed:
                    return options;
                case OptionsMode.Relative:
                    return from ^ options;
                default:
                    throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null);
            }
        }

        protected override bool GetRelativeOptions(bool from, bool to)
        {
            return from ^ to;
        }

        protected sealed override void EvaluateState(bool fromValue, bool toValue, float time)
        {
            var value = time < 0.5f ? fromValue : toValue;
            SetCurrentValue(value);
        }

        protected abstract void SetCurrentValue(bool value);
    }
}