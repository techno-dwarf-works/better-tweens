using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class TimeAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.time;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.time = value;
        }
    }
}