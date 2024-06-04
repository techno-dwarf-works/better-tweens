using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class TimeSamplesAudioSourceTween : IntTween<AudioSource>
    {
        protected override int GetCurrentValue()
        {
            return Target.timeSamples;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.timeSamples = value;
        }
    }
}