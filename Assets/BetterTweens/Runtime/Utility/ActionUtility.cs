﻿using System;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime.Utility
{
    public static class ActionUtility
    {
        private static TweensSettings _settings;

        static ActionUtility()
        {
            _settings = TweensSettings.Instance;
        }

        public static bool Validate(Action action, bool logWarning = true)
        {
            var isValid = action != null;
            if (!isValid && logWarning)
            {
                var message = $"{nameof(action)} cannot be null";
                LogUtility.LogWarning(message);
            }

            return isValid;
        }

        public static void Invoke(Action callback)
        {
            if (callback == null)
            {
                return;
            }

            if (!_settings.Current.SafeMode)
            {
                callback();
                return;
            }

            try
            {
                callback();
            }
            catch (Exception exception)
            {
                LogUtility.LogException(exception.Message);
            }
        }
    }
}