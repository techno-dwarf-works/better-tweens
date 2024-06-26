using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Better.Tweens.Runtime.Utility;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Better.Tweens.Runtime
{
    public static class TweenRegistry
    {
        public static event Action<TweenCore> Registered;
        public static event Action<TweenCore> Unregistered;
        
        private static readonly List<TweenCore> _elements;
        
        public static ReadOnlyCollection<TweenCore> Elements { get; }

        static TweenRegistry()
        {
            _elements = new();
            Elements = _elements.AsReadOnly();

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
            Registered?.Invoke(element);
        }

        internal static bool IsRegistered(TweenCore element)
        {
            return _elements.Contains(element);
        }

        internal static void Unregister(TweenCore element)
        {
            if (!_elements.Remove(element))
            {
                var message = $"Element({element}) not registered";
                LogUtility.LogException(message);
                return;
            }

            Unregistered?.Invoke(element);
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
            Registered = null;
            Unregistered = null;
            _elements.Clear();

            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
        }

#endif
    }
}