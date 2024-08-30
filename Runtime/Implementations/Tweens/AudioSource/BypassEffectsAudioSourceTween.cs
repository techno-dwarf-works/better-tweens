using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BypassEffectsAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.bypassEffects;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.bypassEffects == value)
            {
                return;
            }

            Target.bypassEffects = value;
        }
    }
}