using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ForwardTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.forward;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.forward = value;
        }
    }
}