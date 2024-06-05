using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AngularDragRigidbodyTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.angularDrag;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.angularDrag = value;
        }
    }
}