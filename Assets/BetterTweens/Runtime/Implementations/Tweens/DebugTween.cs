using System;
using System.Text;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Logs;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DebugTween : Tween<int>
    {
        private const LogLevel LogLevel = Logs.LogLevel.Debug;
        private const string DefaultId = "DebugTween";

        public int CurrentValue;

        [SerializeField] private string _id = DefaultId;
        [SerializeField] private bool _lowLevel;

        private StringBuilder _stringBuilder = new();

        protected override void OnInitialized()
        {
            Log("Initialized");

            base.OnInitialized();
        }

        protected override int CalculateRelativeFrom(int to, int options)
        {
            var result = to - options;
            var builder = PrebuildLog("Calculated Relative From")
                .AppendFieldLine(nameof(to), to)
                .AppendFieldLine(nameof(options), options)
                .AppendFieldLine(nameof(result), result);

            Log(builder);
            return result;
        }

        protected override int CalculateTo(int from, int options, OptionsMode optionsMode)
        {
            var result = optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.Speed => Mathf.RoundToInt(from + options * Duration),
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };

            var builder = PrebuildLog("Calculated To")
                .AppendFieldLine(nameof(from), from)
                .AppendFieldLine(nameof(options), options)
                .AppendFieldLine(nameof(optionsMode), optionsMode)
                .AppendFieldLine(nameof(result), result);

            Log(builder);
            return result;
        }

        protected override int GetCurrentValue()
        {
            var result = CurrentValue;
            var builder = PrebuildLog("Getting current value")
                .AppendFieldLine(nameof(result), result);

            Log(builder);
            return result;
        }

        protected override int GetRelativeOptions(int from, int to)
        {
            var result = to - from;
            var builder = PrebuildLog("Getting Relative options")
                .AppendFieldLine(nameof(from), from)
                .AppendFieldLine(nameof(to), to)
                .AppendFieldLine(nameof(result), result);

            Log(builder);
            return result;
        }

        protected override void EvaluateState(int fromValue, int toValue, float time)
        {
            var raw = Mathf.Lerp(fromValue, toValue, time);
            CurrentValue = (int)raw;

            if (_lowLevel)
            {
                var builder = PrebuildLog("State Evaluated")
                    .AppendFieldLine(nameof(fromValue), fromValue)
                    .AppendFieldLine(nameof(toValue), toValue)
                    .AppendFieldLine(nameof(time), time);

                Log(builder);
            }
        }

        protected internal override void OnStarted()
        {
            Log("Started");

            base.OnStarted();
        }

        protected override void OnLoopCompleted()
        {
            Log("Loop Completed");

            base.OnLoopCompleted();
        }

        protected override void OnLoopRewound()
        {
            Log("Loop Rewound");

            base.OnLoopRewound();
        }

        protected override void OnPreUpdated(float deltaTime)
        {
            if (_lowLevel)
            {
                var builder = PrebuildLog("Pre-Updated")
                    .AppendFieldLine(nameof(deltaTime), deltaTime);

                Log(builder);
            }

            base.OnPreUpdated(deltaTime);
        }

        protected override void OnPostUpdated(float deltaTime)
        {
            if (_lowLevel)
            {
                var builder = PrebuildLog("Post-Updated")
                    .AppendFieldLine(nameof(deltaTime), deltaTime);

                Log(builder);
            }

            base.OnPostUpdated(deltaTime);
        }

        protected internal override void OnPlay()
        {
            Log("Play");

            base.OnPlay();
        }

        protected internal override void OnRewind()
        {
            Log("Rewind");

            base.OnRewind();
        }

        protected override void OnCompleted()
        {
            Log("Completed");

            base.OnCompleted();
        }

        protected override void OnRewound()
        {
            Log("Rewound");

            base.OnRewound();
        }

        public override void InstantCompleteLoop()
        {
            Log("Instant Complete Loop");

            base.InstantCompleteLoop();
        }

        public override void InstantRewoundLoop()
        {
            Log("Instant Rewound Loop");

            base.InstantRewoundLoop();
        }

        protected internal override void OnRunned()
        {
            Log("Runned");

            base.OnRunned();
        }

        protected internal override void OnPaused()
        {
            Log("Paused");

            base.OnPaused();
        }

        protected internal override void OnStopped()
        {
            Log("Stopped");

            base.OnStopped();
        }

        public override TweenCore InstantRewound()
        {
            Log("Instant Rewound");

            return base.InstantRewound();
        }

        protected override void OnStateChanged()
        {
            Log("State Changed");

            base.OnStateChanged();
        }

        public override bool Equals(object obj)
        {
            var result = base.Equals(obj);

            if (_lowLevel)
            {
                var builder = PrebuildLog("Equals")
                    .AppendFieldLine(nameof(obj), obj)
                    .AppendFieldLine(nameof(result), result);

                Log(builder);
            }

            return result;
        }

        public override void CollectInfo(ref StringBuilder stringBuilder)
        {
            base.CollectInfo(ref stringBuilder);

            stringBuilder.AppendLine()
                .AppendFieldLine(nameof(CurrentValue), CurrentValue);
        }

        private StringBuilder PrebuildLog(string operationName)
        {
            return _stringBuilder.Clear()
                .Append(_id)
                .Append(" - ")
                .AppendLine(operationName);
        }

        private void Log(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine();
            CollectInfo(ref stringBuilder);

            var message = stringBuilder.ToString();
            LogUtility.Log(message, LogLevel);
        }

        private void Log(string operationName)
        {
            var builder = PrebuildLog(operationName);
            Log(builder);
        }
    }
}