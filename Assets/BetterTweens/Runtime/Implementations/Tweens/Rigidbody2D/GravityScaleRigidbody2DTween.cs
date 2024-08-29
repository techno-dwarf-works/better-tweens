using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class GravityScaleRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        protected override float GetCurrentValue()
        {
            return Target.gravityScale;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.gravityScale = value;
        }
    }
}