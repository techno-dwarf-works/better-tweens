using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class DragRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        protected override float GetCurrentValue()
        {
            return Target.drag;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.drag = value;
        }
    }
}