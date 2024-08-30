using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReverbZoneMixAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.reverbZoneMix;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.reverbZoneMix = value;
        }
    }
}