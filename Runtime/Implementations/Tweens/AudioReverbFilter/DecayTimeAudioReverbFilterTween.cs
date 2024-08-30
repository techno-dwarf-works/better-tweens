using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DecayTimeAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.decayTime;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.decayTime = value;
        }
    }
}