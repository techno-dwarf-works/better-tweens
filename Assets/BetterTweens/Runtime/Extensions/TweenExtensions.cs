using System.Collections.Generic;
using Better.Tweens.Runtime.Triggers.ValueOptions;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

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

        public static Tween<TValue, ColorOptions> SetOptions<TValue>(this Tween<TValue, ColorOptions> self, Color color)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            var options = new CustomColorOptions(color);
            return self.SetOptions(options);
        }

        public static IEnumerable<Tween<TValue, ColorOptions>> SetOptions<TValue>(this IEnumerable<Tween<TValue, ColorOptions>> self, Color color)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            foreach (var tween in self)
            {
                tween.SetOptions(color);
            }

            return self;
        }
    }
}