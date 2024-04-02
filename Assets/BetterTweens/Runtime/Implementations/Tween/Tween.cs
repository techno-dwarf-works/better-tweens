using System;
using System.Text;
using Better.Tweens.Runtime.Properties;
using UnityEngine;

// TODO
// Triggers? ENUMS
// SetId = Add-Contains-RemoveTag? tag = object
// Awaiters with crtns? Source+tween events
// Infinity Loops? Prop.bool and stable setters

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Tween<TProperties, TValue, TValueOptions> : TweenCore
        where TProperties : TweenProperties<TValue>, new()
    {
        [SerializeField] private TProperties _properties;
        [SerializeField] private TValueOptions _options;

        public FromMode FromMode => Properties.FromMode;
        
        internal override CoreProperties CoreProperties => _properties;
        protected TProperties Properties => _properties;
        protected TValue FromValue { get; private set; }
        protected TValue ToValue { get; private set; }

        public Tween()
        {
            _properties = new();
        }

        protected override void OnInitialized()
        {
        }

        protected internal override void OnStarted()
        {
            base.OnStarted();

            FromValue = GetFromBy(Properties.FromMode);
            ToValue = CalculateTo(FromValue, _options, _properties.OptionsMode);
        }

        public Tween<TProperties, TValue, TValueOptions> From(TValue value)
        {
            if (ValidateMutable(true))
            {
                Properties.FromMode = FromMode.Properties;
                Properties.FromValue = value;
            }

            return this;
        }

        public Tween<TProperties, TValue, TValueOptions> From()
        {
            if (ValidateMutable(true))
            {
                var value = GetCurrentValue();
                From(value);
            }

            return this;
        }

        public Tween<TProperties, TValue, TValueOptions> FromAuto()
        {
            if (ValidateMutable(true))
            {
                Properties.FromMode = FromMode.Auto;
                Properties.FromValue = default;
            }

            return this;
        }

        private TValue GetFromBy(FromMode mode)
        {
            return mode switch
            {
                FromMode.Auto => GetCurrentValue(),
                FromMode.Properties => Properties.FromValue,
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
            };
        }

        protected abstract TValue CalculateRelativeFrom(TValue to, TValueOptions options);

        protected abstract TValue CalculateTo(TValue from, TValueOptions options, OptionsMode optionsMode);

        public Tween<TProperties, TValue, TValueOptions> SetOptions(TValueOptions options)
        {
            if (ValidateMutable(true))
            {
                _options = options;
            }

            return this;
        }

        public Tween<TProperties, TValue, TValueOptions> SetOptions(TValueOptions options, OptionsMode mode)
        {
            SetOptions(options);
            SetOptionMode(mode);

            return this;
        }

        public Tween<TProperties, TValue, TValueOptions> SetOptionMode(OptionsMode mode)
        {
            if (ValidateMutable(true))
            {
                _properties.OptionsMode = mode;
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

            switch (_properties.LoopMode)
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

            switch (_properties.LoopMode)
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
                .ToString();
        }
    }

    [Serializable]
    public abstract class Tween<TValue, TValueOptions> : Tween<TweenProperties<TValue>, TValue, TValueOptions>
    {
    }

    [Serializable]
    public abstract class Tween<TValue> : Tween<TValue, TValue>
    {
    }
}