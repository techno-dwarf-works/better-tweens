using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ResonanceAudioLowPassFilterTween : FloatTween<AudioLowPassFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.lowpassResonanceQ;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.lowpassResonanceQ = value;
        }
    }
}