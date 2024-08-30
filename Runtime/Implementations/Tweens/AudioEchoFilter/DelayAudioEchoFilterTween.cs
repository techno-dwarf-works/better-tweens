using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DelayAudioEchoFilterTween : FloatTween<AudioEchoFilter>
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