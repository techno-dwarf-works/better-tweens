using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MuteAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.mute;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.mute == value)
            {
                return;
            }

            Target.mute = value;
        }
    }
}