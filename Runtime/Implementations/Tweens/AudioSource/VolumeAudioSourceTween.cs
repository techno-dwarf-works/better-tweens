using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class VolumeAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.volume;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.volume = value;
        }
    }
}