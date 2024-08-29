using System;
using Better.Commons.Runtime.Extensions;

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

        public static bool TryInvokeBySafeMode(Action action, bool logException = true)
        {
            if (action == null)
            {
                return false;
            }

            if (SafeMode)
            {
                return action.TryInvoke(logException);
            }

            action.Invoke();
            return true;
        }

        public static bool TryInvokeBySafeMode<TValue>(Action<TValue> action, TValue value, bool logException = true)
        {
            if (action == null)
            {
                return false;
            }

            if (SafeMode)
            {
                return action.TryInvoke(value, logException);
            }

            action.Invoke(value);
            return true;
        }
    }
}