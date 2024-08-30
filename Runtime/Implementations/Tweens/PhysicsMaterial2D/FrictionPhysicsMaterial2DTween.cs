using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FrictionPhysicsMaterial2DTween : FloatTween<PhysicsMaterial2D>
    {
        protected override float GetCurrentValue()
        {
            return Target.friction;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.friction = value;
        }
    }
}