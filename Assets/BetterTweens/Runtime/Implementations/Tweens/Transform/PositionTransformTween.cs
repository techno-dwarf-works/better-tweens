using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class PositionTransformTween : Vector3Tween<Transform>
    {
        protected override Vector3 GetCurrentValue()
        {
            return Target.position;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Target.position = value;
        }
    }
}