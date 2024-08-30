using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DecayHFRatioAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.decayHFRatio;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.decayHFRatio = value;
        }
    }
}