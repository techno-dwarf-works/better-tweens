using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LocalEulerAnglesTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.localEulerAngles;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.localEulerAngles = value;
        }
    }
}