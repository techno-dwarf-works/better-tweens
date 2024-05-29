using System;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime.Utility
{
    public static class FuncUtility
    {
        private static TweensSettings _settings;

        static FuncUtility()
        {
            _settings = TweensSettings.Instance;
        }

        public static bool Validate<TResult>(Func<TResult> func, bool logError = true)
        {
            var isValid = func != null;
            if (!isValid && logError)
            {
                var message = $"{nameof(func)} cannot be null";
                LogUtility.LogError(message);
            }

            return isValid;
        }

        public static bool Validate<TValue, TResult>(Func<TValue, TResult> func, bool logError = true)
        {
            var isValid = func != null;
            if (!isValid && logError)
            {
                var message = $"{nameof(func)} cannot be null";
                LogUtility.LogError(message);
            }

            return isValid;
        }

        public static bool TryInvoke<TResult>(Func<TResult> func, out TResult result)
        {
            if (!_settings.Current.SafeMode)
            {
                result = func.Invoke();
                return true;
            }

            try
            {
                result = func.Invoke();
                return true;
            }
            catch (Exception exception)
            {
                LogUtility.LogException(exception.Message);
                result = default;
                return false;
            }
        }

        public static bool TryInvoke<TValue, TResult>(Func<TValue, TResult> func, TValue value, out TResult result)
        {
            if (func == null)
            {
                result = default;
                return false;
            }

            if (!_settings.Current.SafeMode)
            {
                result = func.Invoke(value);
                return true;
            }

            try
            {
                result = func.Invoke(value);
                return true;
            }
            catch (Exception exception)
            {
                LogUtility.LogException(exception.Message);
                result = default;
                return false;
            }
        }
    }
}