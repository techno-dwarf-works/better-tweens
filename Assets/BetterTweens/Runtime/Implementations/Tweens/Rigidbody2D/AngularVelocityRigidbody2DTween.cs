using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AngularVelocityRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

        protected override float GetCurrentValue()
        {
            return Target.angularVelocity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.angularVelocity = value;
        }
    }
}