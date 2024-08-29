using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UseGravityRigidbodyTween : BoolTween<Rigidbody>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useGravity;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.useGravity = value;
        }
    }
}