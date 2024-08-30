using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LocalRotationTransformTween : QuaternionTween<Transform>
    {
        protected override Quaternion GetCurrentValue()
        {
            return Target.localRotation;
        }

        protected override void SetCurrentValue(Quaternion value)
        {
            Target.localRotation = value;
        }
    }
}