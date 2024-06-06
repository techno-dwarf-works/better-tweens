using System.Collections.Generic;
using Better.Tweens.Runtime.Data;
using Better.Tweens.Runtime.Utility;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TweenExtensions
    {
        public static Tween<TValue, Vector2> SetOptions<TValue>(this Tween<TValue, Vector2> self, float options)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            var vectorOptions = Vector2.one * options;
            return self.SetOptions(vectorOptions);
        }

        public static IEnumerable<Tween<TValue, Vector2>> SetOptions<TValue>(this IEnumerable<Tween<TValue, Vector2>> self, float options)
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

        public static Tween<TValue, Vector2Int> SetOptions<TValue>(this Tween<TValue, Vector2Int> self, int options)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            var vectorOptions = Vector2Int.one * options;
            return self.SetOptions(vectorOptions);
        }

        public static IEnumerable<Tween<TValue, Vector2Int>> SetOptions<TValue>(this IEnumerable<Tween<TValue, Vector2Int>> self, int options)
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

        public static Tween<TValue, Vector3> SetOptions<TValue>(this Tween<TValue, Vector3> self, float options)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            var vectorOptions = Vector3.one * options;
            return self.SetOptions(vectorOptions);
        }

        public static IEnumerable<Tween<TValue, Vector3>> SetOptions<TValue>(this IEnumerable<Tween<TValue, Vector3>> self, float options)
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

        public static Tween<TValue, Vector3Int> SetOptions<TValue>(this Tween<TValue, Vector3Int> self, int options)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            var vectorOptions = Vector3Int.one * options;
            return self.SetOptions(vectorOptions);
        }

        public static IEnumerable<Tween<TValue, Vector3Int>> SetOptions<TValue>(this IEnumerable<Tween<TValue, Vector3Int>> self, int options)
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

        public static Tween<TValue, Vector4> SetOptions<TValue>(this Tween<TValue, Vector4> self, float options)
        {
            if (self == null)
            {
                var message = $"{nameof(self)} cannot be null";
                LogUtility.LogException(message);
                return self;
            }

            var vectorOptions = Vector4.one * options;
            return self.SetOptions(vectorOptions);
        }

        public static IEnumerable<Tween<TValue, Vector4>> SetOptions<TValue>(this IEnumerable<Tween<TValue, Vector4>> self, float options)
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