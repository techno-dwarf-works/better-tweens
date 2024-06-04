using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class WetMix3AudioChorusFilterTween : FloatTween<AudioChorusFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.wetMix3;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.wetMix3 = value;
        }
    }
}