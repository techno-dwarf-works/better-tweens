using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LevelAudioDistortionFilterTween : FloatTween<AudioDistortionFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.distortionLevel;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.distortionLevel = value;
        }
    }
}