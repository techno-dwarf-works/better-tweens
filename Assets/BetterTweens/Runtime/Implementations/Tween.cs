using System;
using Better.Tweens.Runtime.Properties;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Tween<TTarget, TProperties, TValue, TValueOptions> : TweenCore
        where TProperties : TweenProperties, new()
    {
        [SerializeField] private TTarget _target;
        [SerializeField] private TProperties _properties;
        [SerializeField] private TValueOptions _options;

        protected internal override TweenProperties Properties => _properties;
        protected TValue FromValue { get; private set; }
        protected TValue ToValue { get; private set; }

        protected override void Initialize()
        {
            base.Initialize();
            if (!Initialized) return; // TODO

            _properties = new();
            From();
        }

        protected override void OnStarted()
        {
            base.OnStarted();

            ToValue = FindTo(FromValue, _options, _properties.OptionsMode);
        }

        public void From(TValue value)
        {
            FromValue = value;
        }

        public void From()
        {
            var value = GetCurrentValue();
            From(value);
        }

        protected abstract TValue FindRelativeFrom(TValue to, TValueOptions options);

        public void SetOptions(TValueOptions options, OptionsMode mode)
        {
            _options = options;
            // _properties.Mode = mode;
        
            // TODO maybe recalculate???
        }

        public void SetOptions(TValueOptions options)
        {
            TryInitialize(); // TODO
            SetOptions(options, _properties.OptionsMode);
        }

        protected abstract TValue FindTo(TValue from, TValueOptions options, OptionsMode optionsMode);

        protected abstract TValue GetCurrentValue();

        protected override void OnLoopCompleted()
        {
            base.OnLoopCompleted();

            if (!IsPlaying()) // TODO check
            {
                return;
            }

            switch (_properties.Mode)
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

            if (!IsPlaying()) // TODO check
            {
                return;
            }

            switch (_properties.Mode)
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

        protected abstract TValueOptions GetRelativeOptions(TValue from, TValue to);
    }

    [Serializable]
    public abstract class Tween<TTarget, TValue, TValueOptions> : Tween<TTarget, TweenProperties, TValue, TValueOptions>
    {
        // TODO: Add ctors
    }

    [Serializable]
    public abstract class Tween<TTarget, TValue> : Tween<TTarget, TValue, TValue>
    {
        // TODO: Add ctors
    }

    [Serializable]
    public abstract class Tween<TTarget> : Tween<TTarget, TTarget>
    {
        // TODO: Add ctors
    }
}