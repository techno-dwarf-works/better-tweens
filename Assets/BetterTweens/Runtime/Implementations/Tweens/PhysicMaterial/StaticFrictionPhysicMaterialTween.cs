using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StaticFrictionPhysicMaterialTween : FloatTween<PhysicMaterial>
    {
        protected override float GetCurrentValue()
        {
            return Target.staticFriction;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.staticFriction = value;
        }
    }
}