using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DryMixAudioEchoFilterTween : FloatTween<AudioEchoFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.dryMix;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.dryMix = value;
        }
    }
}