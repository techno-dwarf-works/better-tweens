using System;
using System.Text;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Tween<TValue, TValueOptions> : TweenCore
    {
        [SerializeField] private FromMode _fromMode;
        [SerializeField] private TValue _fromValue; // TODO name conflict with property
        [SerializeField] private OptionsMode _optionsMode;
        [SerializeField] private TValueOptions _options;

        public OptionsMode OptionsMode => _optionsMode;
        public FromMode FromMode => _fromMode;

        protected TValue FromValue { get; private set; }
        protected TValue ToValue { get; private set; }

        protected override void OnInitialized()
        {
        }

        protected internal override void OnStarted()
        {
            base.OnStarted();

            FromValue = GetFromBy(FromMode);
            ToValue = CalculateTo(FromValue, _options, OptionsMode);
        }

        public Tween<TValue, TValueOptions> From(TValue value)
        {
            if (ValidateMutable(true))
            {
                _fromMode = FromMode.Properties;
                _fromValue = value;
            }

            return this;
        }

        public Tween<TValue, TValueOptions> From()
        {
            if (ValidateMutable(true))
            {
                var value = GetCurrentValue();
                From(value);
            }

            return this;
        }

        public Tween<TValue, TValueOptions> FromAuto()
        {
            if (ValidateMutable(true))
            {
                _fromMode = FromMode.Auto;
                _fromValue = default;
            }

            return this;
        }

        private TValue GetFromBy(FromMode mode)
        {
            return mode switch
            {
                FromMode.Auto => GetCurrentValue(),
                FromMode.Properties => _fromValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
            };
        }

        protected abstract TValue CalculateRelativeFrom(TValue to, TValueOptions options);

        protected abstract TValue CalculateTo(TValue from, TValueOptions options, OptionsMode optionsMode);

        public Tween<TValue, TValueOptions> SetOptions(TValueOptions options)
        {
            if (ValidateMutable(true))
            {
                _options = options;
            }

            return this;
        }

        public Tween<TValue, TValueOptions> SetOptions(TValueOptions options, OptionsMode mode)
        {
            SetOptions(options);
            SetOptionMode(mode);

            return this;
        }

        public Tween<TValue, TValueOptions> SetOptionMode(OptionsMode mode)
        {
            if (ValidateMutable(true))
            {
                _optionsMode = mode;
            }

            return this;
        }

        protected abstract TValue GetCurrentValue();

        protected abstract TValueOptions GetRelativeOptions(TValue from, TValue to);

        protected override void OnLoopCompleted()
        {
            base.OnLoopCompleted();

            if (IsStopped())
            {
                return;
            }

            switch (LoopMode)
            {
                case LoopMode.Restart:
                case LoopMode.PingPong:
                    break;
                case LoopMode.Incremental:
                    var relativeOptions = GetRelativeOptions(FromValue, ToValue);
                    FromValue = ToValue;
                    ToValue = CalculateTo(FromValue, relativeOptions, OptionsMode.Relative);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override void OnLoopRewound()
        {
            base.OnLoopRewound();

            if (IsStopped() || CompletedLoops <= 0)
            {
                return;
            }

            switch (LoopMode)
            {
                case LoopMode.Restart:
                case LoopMode.PingPong:
                    break;
                case LoopMode.Incremental:
                    var relativeOptions = GetRelativeOptions(FromValue, ToValue);
                    ToValue = FromValue;
                    FromValue = CalculateRelativeFrom(ToValue, relativeOptions);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            const string separator = ": ";

            var source = base.ToString();
            return new StringBuilder(source)
                .AppendJoin(separator, nameof(FromValue), FromValue)
                .AppendJoin(separator, nameof(ToValue), ToValue)
                .AppendJoin(separator, nameof(OptionsMode), OptionsMode)
                .AppendJoin(separator, nameof(FromMode), FromMode)
                .ToString();
        }
    }

    [Serializable]
    public abstract class Tween<TValue> : Tween<TValue, TValue>
    {
    }
}