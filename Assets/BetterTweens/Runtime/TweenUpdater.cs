using System.Collections.Generic;
using Better.Commons.Runtime.Utility;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Better.Tweens.Runtime
{
    internal static class TweenUpdater
    {
        private static List<TweenCore> _cachedReferences;

        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            _cachedReferences = new();

            PlayerLoopUtility.SubscribeToLoop(typeof(Update), OnUpdate);
            PlayerLoopUtility.SubscribeToLoop(typeof(PreLateUpdate), OnLateUpdate);
            PlayerLoopUtility.SubscribeToLoop(typeof(FixedUpdate), OnFixedUpdate);
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
            TweenRegistry.CollectElementsBy(updateMode, ref _cachedReferences);
            foreach (var tweenCore in _cachedReferences)
            {
                var progress = tweenCore.DependUnityTimeScale ? scaledDeltaTime : unscaledDeltaTime;
                tweenCore.OnUpdate(progress);
            }

            _cachedReferences.Clear();
        }
    }
}