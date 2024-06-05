using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class EulerAnglesTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.eulerAngles;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.eulerAngles = value;
        }
    }
}