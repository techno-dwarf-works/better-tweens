using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class RotationRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

        protected override float GetCurrentValue()
        {
            return Target.rotation;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.MoveRotation(value);
        }
    }
}