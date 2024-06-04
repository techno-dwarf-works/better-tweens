using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SpreadAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.spread;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.spread = value;
        }
    }
}