using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class IsKinematicRigidbody2DTween : BoolTween<Rigidbody>
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