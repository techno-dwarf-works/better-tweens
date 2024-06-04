using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class HFReferenceAudioReverbZoneTween : FloatTween<AudioReverbZone>
    {
        protected override float GetCurrentValue()
        {
            return Target.HFReference;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.HFReference = value;
        }
    }
}