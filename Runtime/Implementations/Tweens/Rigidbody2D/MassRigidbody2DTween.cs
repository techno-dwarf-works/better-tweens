using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MassRigidbody2DTween : FloatTween<Rigidbody2D>
    {
        protected override float GetCurrentValue()
        {
            return Target.mass;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.mass = value;
        }
    }
}