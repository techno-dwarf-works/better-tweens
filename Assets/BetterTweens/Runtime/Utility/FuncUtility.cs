using System;
using Better.Commons.Runtime.Extensions;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime.Utility
{
    public static class FuncUtility
    {
        private static TweensSettings Settings { get; }
        private static bool SafeMode => Settings.Current.SafeMode;

        static FuncUtility()
        {
            Settings = TweensSettings.Instance;
        }

        public static bool TryInvokeBySafe<TResult>(Func<TResult> func, out TResult result, bool logException = true)
        {
            if (func == null)
            {
                result = default;
                return false;
            }

            if (SafeMode)
            {
                return func.TryInvoke(out result, logException);
            }

            result = func.Invoke();
            return true;
        }

        public static bool TryInvokeBySafe<TValue, TResult>(Func<TValue, TResult> func, TValue value, out TResult result, bool logException = true)
        {
            if (func == null)
            {
                result = default;
                return false;
            }

            if (SafeMode)
            {
                return func.TryInvoke(value, out result, logException);
            }

            result = func.Invoke(value);
            return true;
        }
    }
}