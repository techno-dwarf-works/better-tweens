using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DecayTimeAudioReverbZoneTween : FloatTween<AudioReverbZone>
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