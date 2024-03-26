using System;
using UnityEngine.PlayerLoop;

namespace Better.Tweens.Runtime
{
    public static class UpdateModeExtensions
    {
        public static Type ToPlayerLoopType(this UpdateMode self)
        {
            return self switch
            {
                UpdateMode.Update => typeof(Update),
                UpdateMode.LateUpdate => typeof(PreLateUpdate.ScriptRunBehaviourLateUpdate),
                UpdateMode.FixedUpdate => typeof(FixedUpdate.ScriptRunBehaviourFixedUpdate),
                _ => throw new ArgumentOutOfRangeException(nameof(self), self, null)
            };
        }
    }
}