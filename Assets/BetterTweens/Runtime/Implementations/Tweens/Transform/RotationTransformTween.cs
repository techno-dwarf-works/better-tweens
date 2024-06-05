using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class RotationTransformTween : QuaternionTween<Transform>
    {
        protected override Quaternion GetCurrentValue()
        {
            return Target.rotation;
        }

        protected override void SetCurrentValue(Quaternion value)
        {
            Target.rotation = value;
        }
    }
}