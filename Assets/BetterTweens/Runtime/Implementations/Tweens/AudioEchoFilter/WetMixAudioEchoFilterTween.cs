using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WetMixAudioEchoFilterTween : FloatTween<AudioEchoFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.wetMix;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.wetMix = value;
        }
    }
}