using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class IsKinematicRigidbodyTween : BoolTween<Rigidbody>
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