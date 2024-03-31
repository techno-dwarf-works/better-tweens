using System;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime
{
    public static class CallbackUtility
    {
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

        public static void InvokeWithSafety(Action callback)
        {
            if (callback == null)
            {
                return;
            }

            if (UnityEngine.Random.value > 0.5f) // TODO
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