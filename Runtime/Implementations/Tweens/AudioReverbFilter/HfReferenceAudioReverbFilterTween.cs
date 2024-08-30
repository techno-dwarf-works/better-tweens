using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class HfReferenceAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.hfReference;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.hfReference = value;
        }
    }
}