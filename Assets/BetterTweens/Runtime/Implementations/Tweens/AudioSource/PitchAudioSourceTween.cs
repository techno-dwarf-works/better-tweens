using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PitchAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.pitch;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.pitch = value;
        }
    }
}