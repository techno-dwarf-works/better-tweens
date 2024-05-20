using System;
using Better.Attributes.Runtime.Select;
using UnityEngine;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SleepingDurationOverridable : SimpleOverridable<SleepingDuration>
    {
        public float Duration => Value.Value;
        public bool Infinity => Value.Infinity;

        public SleepingDurationOverridable(SleepingDuration overridenValue) : base(overridenValue)
        {
        }

        public void OverrideDuration(float value)
        {
            Overriden = true;
            OverridenValue.SetValue(value);
        }

        public void OverrideInfinity()
        {
            Overriden = true;
            OverridenValue.MakeInfinity();
        }
    }
}