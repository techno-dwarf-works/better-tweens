using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SpatializePostEffectsAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.spatializePostEffects;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.spatializePostEffects == value)
            {
                return;
            }

            Target.spatializePostEffects = value;
        }
    }
}