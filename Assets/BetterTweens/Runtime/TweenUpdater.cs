using System.Collections.Generic;
using Better.Extensions.Runtime;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Better.Tweens.Runtime
{
    internal static class TweenUpdater
    {
        private static TweensSettings _settings;
        private static List<TweenCore> _cachedReferences;

        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            _settings = TweensSettings.Instance;
            _cachedReferences = new();

            PlayerLoopUtility.SubscribeToLoop(typeof(Update), OnUpdate);
            PlayerLoopUtility.SubscribeToLoop(typeof(PreLateUpdate), OnLateUpdate);
            PlayerLoopUtility.SubscribeToLoop(typeof(FixedUpdate), OnFixedUpdate);
        }

        private static void OnUpdate()
        {
            Tick(UpdateMode.Update, Time.deltaTime, Time.unscaledDeltaTime);
        }

        private static void OnLateUpdate()
        {
            Tick(UpdateMode.LateUpdate, Time.deltaTime, Time.unscaledDeltaTime);
        }

        private static void OnFixedUpdate()
        {
            Tick(UpdateMode.FixedUpdate, Time.fixedDeltaTime, Time.fixedUnscaledDeltaTime);
        }

        private static void Tick(UpdateMode updateMode, float scaledDeltaTime, float unscaledDeltaTime)
        {
            TweenRegistry.CollectElementsBy(updateMode, ref _cachedReferences);
            foreach (var tweenCore in _cachedReferences)
            {
                var progress = tweenCore.DependUnityTimeScale ? scaledDeltaTime : unscaledDeltaTime;
                tweenCore.ApplyProgress(progress);
            }

            _cachedReferences.Clear();
        }
    }
}