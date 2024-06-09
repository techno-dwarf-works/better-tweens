using System.Collections.Generic;
using Better.Commons.Runtime.Utility;
using Better.Tweens.Runtime.Utility;
using UnityEngine;
using UnityEngine.PlayerLoop;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Better.Tweens.Runtime
{
    internal static class TweenUpdater
    {
        private static ICollection<TweenCore> _cachedReferences;

        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            _cachedReferences = new List<TweenCore>();

            PlayerLoopUtility.SubscribeToLoop(typeof(Update), OnUpdate);
            PlayerLoopUtility.SubscribeToLoop(typeof(PreLateUpdate), OnLateUpdate);
            PlayerLoopUtility.SubscribeToLoop(typeof(FixedUpdate), OnFixedUpdate);

#if UNITY_EDITOR
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
#endif
        }

        private static void OnUpdate()
        {
            Update(UpdateMode.Update, Time.deltaTime, Time.unscaledDeltaTime);
        }

        private static void OnLateUpdate()
        {
            Update(UpdateMode.LateUpdate, Time.deltaTime, Time.unscaledDeltaTime);
        }

        private static void OnFixedUpdate()
        {
            Update(UpdateMode.FixedUpdate, Time.fixedDeltaTime, Time.fixedUnscaledDeltaTime);
        }

        private static void Update(UpdateMode updateMode, float scaledDeltaTime, float unscaledDeltaTime)
        {
            _cachedReferences.Clear();
            CollectElementsBy(updateMode, ref _cachedReferences);

            foreach (var tweenCore in _cachedReferences)
            {
                var progress = tweenCore.DependUnityTimeScale ? scaledDeltaTime : unscaledDeltaTime;
                tweenCore.OnUpdate(progress);
            }
        }

        private static void CollectElementsBy(UpdateMode updateMode, ref ICollection<TweenCore> references)
        {
            if (references == null)
            {
                var message = $"{nameof(references)} cannot be null";
                LogUtility.LogException(message);
                return;
            }

            foreach (var element in TweenRegistry.Elements)
            {
                if (element.UpdateMode == updateMode)
                {
                    references.Add(element);
                }
            }
        }

#if UNITY_EDITOR

        private static void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingPlayMode)
            {
                OnExitingPlayMode();
            }

            MonoBehaviour someMonoBeh = new();


            someMonoBeh.TweensTagged().Stop();
        }

        private static void OnExitingPlayMode()
        {
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;

            PlayerLoopUtility.UnsubscribeFromLoop(typeof(Update), OnUpdate);
            PlayerLoopUtility.UnsubscribeFromLoop(typeof(PreLateUpdate), OnLateUpdate);
            PlayerLoopUtility.UnsubscribeFromLoop(typeof(FixedUpdate), OnFixedUpdate);
        }

#endif
    }
}