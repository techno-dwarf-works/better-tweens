using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WetMix1AudioChorusFilterTween : FloatTween<AudioChorusFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.wetMix1;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.wetMix1 = value;
        }
    }
}