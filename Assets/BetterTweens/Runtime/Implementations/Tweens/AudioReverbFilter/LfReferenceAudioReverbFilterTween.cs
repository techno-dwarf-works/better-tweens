using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LfReferenceAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.lfReference;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.lfReference = value;
        }
    }
}