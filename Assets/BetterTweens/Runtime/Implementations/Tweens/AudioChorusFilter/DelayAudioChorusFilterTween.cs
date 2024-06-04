using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DelayAudioChorusFilterTween : FloatTween<AudioChorusFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.delay;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.delay = value;
        }
    }
}