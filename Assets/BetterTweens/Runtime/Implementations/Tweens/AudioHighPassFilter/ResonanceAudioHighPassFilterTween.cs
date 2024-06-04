using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ResonanceAudioHighPassFilterTween : FloatTween<AudioHighPassFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.highpassResonanceQ;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.highpassResonanceQ = value;
        }
    }
}