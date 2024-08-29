using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class KinematicRigidbodyTween : BoolTween<Rigidbody>
    {
        protected override bool GetCurrentValue()
        {
            return Target.isKinematic;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.isKinematic = value;
        }
    }
}