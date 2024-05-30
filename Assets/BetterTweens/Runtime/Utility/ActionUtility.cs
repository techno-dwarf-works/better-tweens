using System;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime.Utility
{
    public static class ActionUtility
    {
        private static TweensSettings Settings { get; }
        private static bool SafeMode => Settings.Current.SafeMode;

        static ActionUtility()
        {
            Settings = TweensSettings.Instance;
        }

        public static bool Validate(Action action, bool logException = true)
        {
            var isValid = action != null;
            if (!isValid && logException)
            {
                var message = $"{nameof(action)} cannot be null";
                LogUtility.LogException(message);
            }

            return isValid;
        }

        public static bool TryInvokeBySafe(Action action, bool logException = true)
        {
            if (SafeMode)
            {
                return action.TryInvoke(logException);
            }

            action.Invoke();
            return true;
        }

        public static bool TryInvokeBySafe<TValue>(Action<TValue> action, TValue value, bool logException = true)
        {
            if (SafeMode)
            {
                return action.TryInvoke(value, logException);
            }

            action.Invoke(value);
            return true;
        }
    }
}