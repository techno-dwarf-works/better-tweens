using System;
using Better.Commons.Runtime.Interfaces;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SleepingDurationOverridable : ImplementationOverridable<SleepingDuration>, ICloneable<SleepingDurationOverridable>
    {
        public float Duration => Value.Value;
        public bool Infinity => Value.Infinity;

        public SleepingDurationOverridable(SleepingDuration overridenValue) : base(overridenValue)
        {
        }

        public SleepingDurationOverridable(SleepingDuration overridenValue, SleepingDuration sourceValue, bool overriden) : base(overridenValue)
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

        public new SleepingDurationOverridable Clone()
        {
            var overridenClone = OverridenValue?.Clone();
            return new SleepingDurationOverridable(overridenClone, SourceValue, Overriden);
        }
    }
}