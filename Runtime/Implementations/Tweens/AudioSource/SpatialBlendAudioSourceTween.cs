using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SpatialBlendAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.spatialBlend;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.spatialBlend = value;
        }
    }
}