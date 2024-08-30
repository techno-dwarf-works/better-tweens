using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class IgnoreListenerPauseAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.ignoreListenerPause;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.ignoreListenerPause == value)
            {
                return;
            }

            Target.ignoreListenerPause = value;
        }
    }
}