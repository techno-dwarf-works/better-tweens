using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DepthAudioChorusFilterTween : FloatTween<AudioChorusFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.depth;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.depth = value;
        }
    }
}