using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FrequencyAudioLowPassFilterTween : FloatTween<AudioLowPassFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.cutoffFrequency;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.cutoffFrequency = value;
        }
    }
}