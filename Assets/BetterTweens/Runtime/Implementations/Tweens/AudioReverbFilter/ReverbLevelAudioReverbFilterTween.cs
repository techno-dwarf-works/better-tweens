using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReverbLevelAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.reverbLevel;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.reverbLevel = value;
        }
    }
}