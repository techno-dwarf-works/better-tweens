using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class KinematicRigidbody2DTween : BoolTween<Rigidbody2D>
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