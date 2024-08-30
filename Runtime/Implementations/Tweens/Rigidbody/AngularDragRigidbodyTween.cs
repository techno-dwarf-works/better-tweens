using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AngularDragRigidbodyTween : FloatTween<Rigidbody>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

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