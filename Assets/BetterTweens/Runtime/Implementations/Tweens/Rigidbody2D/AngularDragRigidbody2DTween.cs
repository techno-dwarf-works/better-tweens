using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AngularDragRigidbody2DTween : FloatTween<Rigidbody>
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