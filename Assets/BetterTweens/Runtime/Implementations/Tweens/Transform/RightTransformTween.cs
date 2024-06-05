using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class RightTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.right;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.right = value;
        }
    }
}