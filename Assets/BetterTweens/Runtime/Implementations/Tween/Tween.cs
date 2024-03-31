using System;
using System.Text;
using Better.Tweens.Runtime.Properties;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Tween<TProperties, TValue, TValueOptions> : TweenCore
        where TProperties : TweenProperties, new()
    {
        [SerializeField] private TProperties _properties;
        [SerializeField] private TValueOptions _options;

        internal override TweenProperties DerivedProperties => _properties;
        protected TProperties Properties => _properties;
        protected TValue FromValue { get; private set; }
        protected TValue ToValue { get; private set; }

        protected Tween()
        {
            _properties = new();
        }

        protected override void OnInitialized()
        {
            From();
        }

        protected internal override void OnStarted()
        {
            base.OnStarted();

            ToValue = FindTo(FromValue, _options, _properties.OptionsMode);
        }

        public Tween<TProperties, TValue, TValueOptions> From(TValue value)
        {
            if (ValidateMutable(true))
            {
                FromValue = value;
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

        public Tween<TProperties, TValue, TValueOptions> SetOptions(TValueOptions options, OptionsMode mode)
        {
            if (ValidateMutable(true))
            {
                _options = options;
                _properties.OptionsMode = mode;
            }

            return this;
        }

        public Tween<TProperties, TValue, TValueOptions> SetOptions(TValueOptions options)
        {
            SetOptions(options, _properties.OptionsMode);

            return this;
        }

        protected abstract TValue GetCurrentValue();
        protected abstract TValue FindTo(TValue from, TValueOptions options, OptionsMode optionsMode);
        protected abstract TValue FindRelativeFrom(TValue to, TValueOptions options);
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
                    ToValue = FindTo(FromValue, relativeOptions, OptionsMode.Relative);
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
                    FromValue = FindRelativeFrom(ToValue, relativeOptions);
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
    public abstract class Tween<TValue, TValueOptions> : Tween<TweenProperties, TValue, TValueOptions>
    {
    }

    [Serializable]
    public abstract class Tween<TValue> : Tween<TValue, TValue>
    {
    }
}