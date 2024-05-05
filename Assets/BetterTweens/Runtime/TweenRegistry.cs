using System.Collections.Generic;
using Better.Tweens.Runtime.Utility;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Better.Tweens.Runtime
{
    public static class TweenRegistry
    {
        private static readonly List<TweenCore> _elements;
        private static List<TweenCore> _cachedReferences;

        static TweenRegistry()
        {
            _elements = new();
            _cachedReferences = new();

#if UNITY_EDITOR
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
#endif
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
            if (_elements.Remove(element))
            {
                return;
            }

            var message = $"Element({element}) not registered";
            LogUtility.LogException(message);
        }

        public static void CollectElementsBy(UpdateMode updateMode, ref List<TweenCore> references)
        {
            if (references == null)
            {
                var message = $"{nameof(references)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            foreach (var element in _elements)
            {
                if (element.UpdateMode == updateMode)
                {
                    references.Add(element);
                }
            }
        }

        public static TweenCore[] GetElementsBy(UpdateMode updateMode)
        {
            _cachedReferences.Clear();
            CollectElementsBy(updateMode, ref _cachedReferences);

            return _cachedReferences.ToArray();
        }

        public static void CollectElementsBy(object tag, ref List<TweenCore> references)
        {
            if (tag == null)
            {
                var message = $"{nameof(tag)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            if (references == null)
            {
                var message = $"{nameof(references)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            foreach (var element in _elements)
            {
                if (element.ContainsTag(tag))
                {
                    references.Add(element);
                }
            }
        }

        public static TweenCore[] GetElementsBy(object tag)
        {
            _cachedReferences.Clear();
            CollectElementsBy(tag, ref _cachedReferences);

            return _cachedReferences.ToArray();
        }

#if UNITY_EDITOR

        private static void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingPlayMode)
            {
                OnExitingPlayMode();
            }
        }

        private static void OnExitingPlayMode()
        {
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;

            _elements.Clear();
            _cachedReferences.Clear();
        }

#endif
    }
}