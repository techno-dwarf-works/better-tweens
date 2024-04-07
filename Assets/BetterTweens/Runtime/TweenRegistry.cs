using System.Collections.Generic;
using Better.Tweens.Runtime.Logs;

namespace Better.Tweens.Runtime
{
    public static class TweenRegistry
    {
        private static List<TweenCore> _elements;

        static TweenRegistry()
        {
            _elements = new();
        }

        internal static void Register(TweenCore element)
        {
            if (IsRegistered(element))
            {
                var message = $"Element({element}) already registered";
                LogUtility.LogException(message);

                return;
            }

            _elements.Add(element);
        }

        internal static bool IsRegistered(TweenCore element)
        {
            return _elements.Contains(element);
        }

        internal static void Unregister(TweenCore element)
        {
            if (!IsRegistered(element))
            {
                var message = $"Element({element}) not registered";
                LogUtility.LogException(message);

                return;
            }

            _elements.Remove(element);
        }

        public static void CollectElementsBy(UpdateMode updateMode, ref List<TweenCore> elements)
        {
            if (elements == null)
            {
                var message = $"{nameof(elements)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            foreach (var element in _elements)
            {
                if (element.UpdateMode == updateMode)
                {
                    elements.Add(element);
                }
            }
        }
    }
}