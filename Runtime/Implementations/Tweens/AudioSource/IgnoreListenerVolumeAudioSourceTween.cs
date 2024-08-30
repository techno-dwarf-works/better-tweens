using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class IgnoreListenerVolumeAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.ignoreListenerVolume;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.ignoreListenerVolume == value)
            {
                return;
            }

            Target.ignoreListenerVolume = value;
        }
    }
}