using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MaxDepenetrationVelocityRigidbodyTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.maxDepenetrationVelocity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.maxDepenetrationVelocity = value;
        }
    }
}