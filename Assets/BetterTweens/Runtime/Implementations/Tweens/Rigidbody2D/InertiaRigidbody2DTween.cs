using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class InertiaRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

        protected override float GetCurrentValue()
        {
            return Target.inertia;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.inertia = value;
        }
    }
}