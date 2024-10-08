﻿using System;
using System.Text;
using Better.Commons.Runtime.Extensions;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public abstract class Tween : ProgressableCore
    {
    }

    [Serializable]
    public abstract class Tween<TValue, TValueOptions> : Tween
    {
        [SerializeField] private FromMode _fromMode;
        [SerializeField] private TValue _fromValue;
        [SerializeField] private OptionsMode _optionsMode;

        [SerializeReference, SerializeField] private TValueOptions _options;

        public OptionsMode OptionsMode => _optionsMode;
        public FromMode FromMode => _fromMode;

        protected TValue FromValue { get; private set; }
        protected TValue ToValue { get; private set; }

        protected internal override void OnStarted()
        {
            FromValue = GetFromBy(FromMode);
            ToValue = CalculateTo(FromValue, _options, OptionsMode);

            base.OnStarted();
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

        public Tween<TValue, TValueOptions> SetOptionsMode(OptionsMode mode)
        {
            if (ValidateMutable(true))
            {
                _optionsMode = mode;
            }

            return this;
        }

        protected abstract TValue GetCurrentValue();

        protected abstract TValueOptions GetRelativeOptions(TValue from, TValue to);

        protected sealed override void EvaluateState(float time)
        {
            EvaluateState(FromValue, ToValue, time);
        }

        protected abstract void EvaluateState(TValue fromValue, TValue toValue, float time);

        protected override void OnLoopCompleted()
        {
            var rootStateToken = GetHandlingStateToken();
            base.OnLoopCompleted();

            if (rootStateToken.IsCancellationRequested)
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
            var rootStateToken = GetHandlingStateToken();
            base.OnLoopRewound();

            if (rootStateToken.IsCancellationRequested)
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

        public override bool IsBroken()
        {
            if (FromMode == FromMode.Properties
                && _fromValue == null)
            {
                return true;
            }

            if (_options == null)
            {
                return true;
            }

            return base.IsBroken();
        }

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendFieldLine(nameof(_options), _options)
                .AppendFieldLine(nameof(OptionsMode), OptionsMode)
                .AppendFieldLine(nameof(FromMode), FromMode)
                .AppendFieldLine(nameof(FromValue), FromValue)
                .AppendFieldLine(nameof(ToValue), ToValue);
        }

        public override TweenCore As(TweenCore source)
        {
            if (ValidateMutable(true, false)
                && source is Tween<TValue, TValueOptions> tweenSource)
            {
                _fromMode = tweenSource._fromMode;
                _fromValue = tweenSource._fromValue;
                _optionsMode = tweenSource._optionsMode;
                _options = tweenSource._options;
            }

            return base.As(source);
        }
    }

    [Serializable]
    public abstract class Tween<TValue> : Tween<TValue, TValue>
    {
    }
}