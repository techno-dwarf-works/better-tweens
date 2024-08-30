using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DecayRatioAudioEchoFilterTween : FloatTween<AudioEchoFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.decayRatio;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.decayRatio = value;
        }
    }
}