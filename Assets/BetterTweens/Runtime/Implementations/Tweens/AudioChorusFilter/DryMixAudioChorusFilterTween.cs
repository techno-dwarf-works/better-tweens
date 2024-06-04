using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DryMixAudioChorusFilterTween : FloatTween<AudioChorusFilter>
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