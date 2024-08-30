using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RateAudioChorusFilterTween : FloatTween<AudioChorusFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.rate;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.rate = value;
        }
    }
}