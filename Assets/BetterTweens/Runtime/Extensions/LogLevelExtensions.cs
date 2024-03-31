using System;
using Better.Tweens.Runtime.Logs;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class LogLevelExtensions
    {
        public static LogType ToLogType(this LogLevel self)
        {
            return self switch
            {
                LogLevel.Debug => LogType.Log,
                LogLevel.Info => LogType.Log,
                LogLevel.Warning => LogType.Warning,
                LogLevel.Error => LogType.Error,
                LogLevel.Exception => LogType.Exception,
                _ => throw new ArgumentOutOfRangeException(nameof(self), self, null)
            };
        }
    }
}