using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

namespace Better.Tweens.Runtime
{
    public static class TweenExtensions
    {
        public static IEnumerable<Tween<TValue, TValueOptions>> From<TValue, TValueOptions>(this IEnumerable<Tween<TValue, TValueOptions>> self, TValue value)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.From(value);
            }

            return self;
        }

        public static IEnumerable<Tween<TValue, TValueOptions>> From<TValue, TValueOptions>(this IEnumerable<Tween<TValue, TValueOptions>> self)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.From();
            }

            return self;
        }

        public static IEnumerable<Tween<TValue, TValueOptions>> FromAuto<TValue, TValueOptions>(this IEnumerable<Tween<TValue, TValueOptions>> self)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.FromAuto();
            }

            return self;
        }

        public static IEnumerable<Tween<TValue, TValueOptions>> SetOptions<TValue, TValueOptions>(this IEnumerable<Tween<TValue, TValueOptions>> self, TValueOptions options)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetOptions(options);
            }

            return self;
        }

        public static IEnumerable<Tween<TValue, TValueOptions>> SetOptions<TValue, TValueOptions>(this IEnumerable<Tween<TValue, TValueOptions>> self, TValueOptions options, OptionsMode optionsMode)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetOptions(options, optionsMode);
            }

            return self;
        }

        public static IEnumerable<Tween<TValue, TValueOptions>> SetOptionsMode<TValue, TValueOptions>(this IEnumerable<Tween<TValue, TValueOptions>> self, OptionsMode optionsMode)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetOptionsMode(optionsMode);
            }

            return self;
        }
    }
}