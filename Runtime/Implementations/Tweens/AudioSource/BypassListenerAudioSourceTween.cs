using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BypassListenerAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.bypassListenerEffects;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.bypassListenerEffects == value)
            {
                return;
            }

            Target.bypassListenerEffects = value;
        }
    }
}