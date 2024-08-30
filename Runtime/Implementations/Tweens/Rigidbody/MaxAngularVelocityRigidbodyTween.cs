using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MaxAngularVelocityRigidbodyTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.maxAngularVelocity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.maxAngularVelocity = value;
        }
    }
}