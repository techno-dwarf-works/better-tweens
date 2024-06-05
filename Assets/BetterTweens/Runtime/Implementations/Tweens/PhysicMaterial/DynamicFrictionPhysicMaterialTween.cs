using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class DynamicFrictionPhysicMaterialTween : FloatTween<PhysicMaterial>
    {
        protected override float GetCurrentValue()
        {
            return Target.dynamicFriction;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.dynamicFriction = value;
        }
    }
}