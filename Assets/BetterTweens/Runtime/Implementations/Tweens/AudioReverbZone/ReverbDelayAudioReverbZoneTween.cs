using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReverbDelayAudioReverbZoneTween : FloatTween<AudioReverbZone>
    {
        protected override float GetCurrentValue()
        {
            return Target.reverbDelay;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.reverbDelay = value;
        }
    }
}