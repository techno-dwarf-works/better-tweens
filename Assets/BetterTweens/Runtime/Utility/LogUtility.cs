using System;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime.Utility
{
    public static class LogUtility
    {
        private static TweensSettings _settings;

        static LogUtility()
        {
            _settings = TweensSettings.Instance;
        }

        public static void Log(string message, LogLevel logLevel)
        {
            if (!AllowLogLevel(logLevel))
            {
                return;
            }

            var logType = logLevel.ToLogType();
            Debug.unityLogger.Log(logType, message);
        }

        public static void LogDebug(string message)
        {
            Log(message, LogLevel.Debug);
        }

        public static void LogInfo(string message)
        {
            Log(message, LogLevel.Info);
        }

        public static void LogWarning(string message)
        {
            Log(message, LogLevel.Warning);
        }

        public static void LogError(string message)
        {
            Log(message, LogLevel.Error);
        }

        public static void LogException(string message)
        {
            Log(message, LogLevel.Exception);
        }

        public static void LogException(Exception exception)
        {
            LogException(exception.Message);
        }

        public static bool AllowLogLevel(LogLevel logLevel)
        {
            return logLevel >= _settings.Current.LogLevel;
        }
    }
}