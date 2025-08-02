using System;
using Better.Commons.Runtime.Interfaces;

namespace Better.Tweens.Runtime.Data
{
    [Serializable]
    public class SleepingDurationOverridable : ImplementationOverridable<SleepingDuration>, ICloneable<SleepingDurationOverridable>
    {
        public float Duration => Value.Value;
        public bool Infinity => Value.Infinity;

        public SleepingDurationOverridable()
        {
        }

        public SleepingDurationOverridable(SleepingDuration overridenValue, SleepingDuration sourceValue, bool overriden) : base(overridenValue, sourceValue, overriden)
        {
        }

        public void OverrideDuration(float value)
        {
            OverridenValue.SetValue(value);
            MarkOverriden();
        }

        public void OverrideInfinity()
        {
            OverridenValue.MakeInfinity();
            MarkOverriden();
        }

        public new SleepingDurationOverridable Clone()
        {
            var overridenClone = OverridenValue?.Clone();
            return new SleepingDurationOverridable(overridenClone, SourceValue, Overriden);
        }
    }
}