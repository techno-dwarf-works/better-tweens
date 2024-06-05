using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class MaxDepenetrationVelocityRigidbody2DTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.maxDepenetrationVelocity;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.maxDepenetrationVelocity = value;
        }
    }
}