using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DragRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        public override UpdateMode UpdateMode => UpdateMode.FixedUpdate;

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