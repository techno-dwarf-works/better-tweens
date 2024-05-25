using System;
using System.Text;
using Better.Tweens.Runtime.Logs;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DebugTween : Tween<int>
    {
        private const string DefaultId = "DebugTween";

        [SerializeField] private string _id = DefaultId;
        [SerializeField] private int _currentValue;
        [SerializeField] private LogLevel _logLevel;

        private StringBuilder _logBuilder = new(); // TODO

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Log("Initialized;");
        }

        protected override int CalculateRelativeFrom(int to, int options)
        {
            var result = to - options;

            _logBuilder.Clear()
                .AppendLine("Relative From calculated;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(to), to)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(options), options)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(result), result)
                .AppendLine();

            LogByBuilder();
            return result;
        }

        protected override int CalculateTo(int from, int options, OptionsMode optionsMode)
        {
            var result = optionsMode switch
            {
                OptionsMode.To => options,
                OptionsMode.Relative => from + options,
                OptionsMode.SpeedBased => Mathf.RoundToInt(from + options * Duration),
                _ => throw new ArgumentOutOfRangeException(nameof(optionsMode), optionsMode, null)
            };

            _logBuilder.Clear()
                .AppendLine("To calculated;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(from), from)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(options), options)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(optionsMode), optionsMode)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(result), result)
                .AppendLine();

            LogByBuilder();
            return result;
        }

        protected override int GetCurrentValue()
        {
            var result = _currentValue;

            _logBuilder.Clear()
                .AppendLine("CurrentValue got;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(result), result)
                .AppendLine();

            LogByBuilder();
            return result;
        }

        protected override int GetRelativeOptions(int from, int to)
        {
            var result = to - from;

            _logBuilder.Clear()
                .AppendLine("Relative options calculated;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(from), from)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(to), to)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(result), result)
                .AppendLine();

            LogByBuilder();
            return result;
        }

        protected override void EvaluateState(int fromValue, int toValue, float time)
        {
            var raw = Mathf.Lerp(fromValue, toValue, time);
            _currentValue = (int)raw;

            _logBuilder.Clear()
                .AppendLine("State evaluated;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(fromValue), fromValue)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(toValue), toValue)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(time), time)
                .AppendLine();

            // LogByBuilder();
        }

        protected internal override void OnStarted()
        {
            Log("Started;");
            base.OnStarted();
        }

        protected override void OnLoopCompleted()
        {
            Log("Loop completed;");
            base.OnLoopCompleted();
        }

        protected override void OnLoopRewound()
        {
            Log("Loop rewound;");
            base.OnLoopRewound();
        }

        protected override void OnCompleted()
        {
            Log("Completed;");
            base.OnCompleted();
        }

        protected override void OnPreUpdated(float deltaTime)
        {
            base.OnPreUpdated(deltaTime);

            _logBuilder.Clear()
                .AppendLine("Pre-Updated;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(deltaTime), deltaTime)
                .AppendLine();

            // LogByBuilder();
        }

        protected override void OnPostUpdated(float deltaTime)
        {
            base.OnPostUpdated(deltaTime);

            _logBuilder.Clear()
                .AppendLine("Post-Updated;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(deltaTime), deltaTime)
                .AppendLine();

            // LogByBuilder();
        }

        protected internal override void OnRunned()
        {
            Log("Runned;");
            base.OnRunned();
        }

        protected internal override void OnPlay()
        {
            Log("Play;");
            base.OnPlay();
        }

        protected internal override void OnRewind()
        {
            Log("Rewind;");
            base.OnRewind();
        }

        protected internal override void OnPaused()
        {
            Log("Paused;");
            base.OnPaused();
        }

        protected internal override void OnStopped()
        {
            Log("Stopped;");
            base.OnStopped();
        }

        protected override void OnRewound()
        {
            Log("Rewound;");
            base.OnRewound();
        }

        protected override void OnStateChanged()
        {
            Log("State changed;");
            base.OnStateChanged();
        }

        public override bool Equals(object obj)
        {
            var result = base.Equals(obj);

            _logBuilder.Clear()
                .AppendLine("Equals;")
                .AppendJoin(LogUtility.NameValueSeparator, nameof(obj), obj)
                .AppendLine()
                .AppendJoin(LogUtility.NameValueSeparator, nameof(result), result)
                .AppendLine();

            LogByBuilder();
            return result;
        }

        private void LogByBuilder()
        {
            _logBuilder.AppendLine();
            CollectInfo(ref _logBuilder);

            var idPrefix = $"({_id}) ";
            _logBuilder.Insert(0, idPrefix);

            var log = _logBuilder.ToString();
            LogUtility.Log(log, _logLevel);
        }

        private void Log(string message)
        {
            _logBuilder.Clear().AppendLine(message);
            LogByBuilder();
        }
    }
}