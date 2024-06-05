using UnityEngine;

namespace Better.Tweens.Runtime
{
    public class AutoSimulationPhysicsTween : BoolTween
    {
        protected override bool GetCurrentValue()
        {
            return Physics.autoSimulation;
        }

        protected override void SetCurrentValue(bool value)
        {
            Physics.autoSimulation = value;
        }
    }
}