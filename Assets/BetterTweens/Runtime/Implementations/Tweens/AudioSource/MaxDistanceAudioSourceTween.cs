using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MaxDistanceAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.maxDistance;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.maxDistance = value;
        }
    }
}