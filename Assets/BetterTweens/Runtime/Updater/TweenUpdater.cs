using Better.Extensions.Runtime;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    public static class TweenUpdater
    {
        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            var playerLoopType = UpdateMode.Update.ToPlayerLoopType();
            PlayerLoopUtility.SubscribeToLoop(playerLoopType, OnUpdate);
            // PlayerLoopUtility.LogCurrentPlayerLoopTypes("lllllllllllllllllllll");
        }

        private static void OnUpdate()
        {
            if(TweenRegistry.TweenCore == null) return;
            
            TweenRegistry.TweenCore.ApplyProgress(Time.deltaTime);
        }
    }
}