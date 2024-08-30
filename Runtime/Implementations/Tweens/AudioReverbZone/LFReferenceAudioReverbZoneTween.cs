using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LFReferenceAudioReverbZoneTween : FloatTween<AudioReverbZone>
    {
        protected override float GetCurrentValue()
        {
            return Target.LFReference;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.LFReference = value;
        }
    }
}