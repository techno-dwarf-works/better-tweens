using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DensityAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.density;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.density = value;
        }
    }
}