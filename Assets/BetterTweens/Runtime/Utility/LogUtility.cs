using System;
using System.Text;
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

        public static void Log(string message, LogLevel logLevel, object context)
        {
            if (!AllowLogLevel(logLevel))
            {
                return;
            }

            message += $"\n{context}";
            Log(message, logLevel);
        }

        public static void LogDebug(string message)
        {
            Log(message, LogLevel.Debug);
        }

        public static void LogDebug(string message, object context)
        {
            Log(message, LogLevel.Debug, context);
        }

        public static void LogInfo(string message)
        {
            Log(message, LogLevel.Info);
        }

        public static void LogInfo(string message, object context)
        {
            Log(message, LogLevel.Info, context);
        }

        public static void LogWarning(string message)
        {
            Log(message, LogLevel.Warning);
        }

        public static void LogWarning(string message, object context)
        {
            Log(message, LogLevel.Warning, context);
        }

        public static void LogError(string message)
        {
            Log(message, LogLevel.Error);
        }

        public static void LogError(string message, object context)
        {
            Log(message, LogLevel.Error, context);
        }

        public static void LogException(string message)
        {
            Log(message, LogLevel.Exception);
        }

        public static void LogException(string message, object context)
        {
            Log(message, LogLevel.Exception, context);
        }

        public static void LogException(Exception exception)
        {
            LogException(exception.Message);
        }

        public static void LogException(Exception exception, object context)
        {
            LogException(exception.Message, context);
        }

        public static bool AllowLogLevel(LogLevel logLevel)
        {
            return logLevel >= _settings.Current.LogLevel;
        }
    }
}