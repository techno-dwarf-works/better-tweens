using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DryLevelAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.dryLevel;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.dryLevel = value;
        }
    }
}