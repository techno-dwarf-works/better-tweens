using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SpatializeAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.spatialize;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.spatialize == value)
            {
                return;
            }

            Target.spatialize = value;
        }
    }
}