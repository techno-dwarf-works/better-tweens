using System.Collections.Generic;
using Better.Extensions.Runtime;
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
            Tick(UpdateMode.Update, Time.deltaTime);
        }

        private static void OnLateUpdate()
        {
            Tick(UpdateMode.LateUpdate, Time.deltaTime);
        }

        private static void OnFixedUpdate()
        {
            Tick(UpdateMode.FixedUpdate, Time.fixedDeltaTime);
        }

        private static void Tick(UpdateMode updateMode, float deltaTime)
        {
            TweenRegistry.CollectElementsBy(updateMode, ref _cachedReferences);
            foreach (var tweenCore in _cachedReferences)
            {
                tweenCore.ApplyProgress(deltaTime);
            }

            _cachedReferences.Clear();
        }
    }
}