using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class DragRigidbodyTween : FloatTween<Rigidbody>
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