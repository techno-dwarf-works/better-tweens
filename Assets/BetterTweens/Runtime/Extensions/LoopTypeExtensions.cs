using System;
using UnityEngine.PlayerLoop;

namespace Better.Tweens.Runtime
{
    public static class LoopTypeExtensions
    {
        public static Type ToPlayerLoopType(this LoopType self)
        {
            return self switch
            {
                LoopType.Update => typeof(Update),
                LoopType.LateUpdate => typeof(PreLateUpdate.ScriptRunBehaviourLateUpdate),
                LoopType.FixedUpdate => typeof(FixedUpdate.ScriptRunBehaviourFixedUpdate),
                _ => throw new ArgumentOutOfRangeException(nameof(self), self, null)
            };
        }
    }
}