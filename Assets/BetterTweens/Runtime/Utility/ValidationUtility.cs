using System;

namespace Better.Tweens.Runtime.Utility
{
    public static class ValidationUtility
    {
        public static bool ValidateNullReference(object value, bool logException = true)
        {
            var isValid = value != null;
            if (!isValid && logException)
            {
                var message = $"{nameof(value)} cannot be null";
                LogUtility.LogException(message);
            }

            return isValid;
        }

        public static bool Validate<TResult>(Func<TResult> func, bool logException = true)
        {
            return ValidateNullReference(func, logException);
        }

        public static bool Validate(Action action, bool logException = true)
        {
            return ValidateNullReference(action, logException);
        }
    }
}