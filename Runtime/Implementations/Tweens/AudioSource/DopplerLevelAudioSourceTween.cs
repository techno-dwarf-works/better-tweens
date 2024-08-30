using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DopplerLevelAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.dopplerLevel;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.dopplerLevel = value;
        }
    }
}