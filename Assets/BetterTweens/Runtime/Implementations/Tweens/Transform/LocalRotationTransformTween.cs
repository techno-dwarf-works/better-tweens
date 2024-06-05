using UnityEngine;

namespace Better.Tweens.Runtime
{
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