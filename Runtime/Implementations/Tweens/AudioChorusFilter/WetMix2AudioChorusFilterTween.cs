using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WetMix2AudioChorusFilterTween : FloatTween<AudioChorusFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.wetMix2;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.wetMix2 = value;
        }
    }
}