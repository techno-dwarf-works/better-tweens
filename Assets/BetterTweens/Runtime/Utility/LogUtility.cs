using UnityEngine;

namespace Better.Tweens.Runtime.Logs
{
    public static class LogUtility
    {
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

        public static bool AllowLogLevel(LogLevel logLevel)
        {
            // TODO Settings
            return logLevel >= LogLevel.Warning;
        }
    }
}