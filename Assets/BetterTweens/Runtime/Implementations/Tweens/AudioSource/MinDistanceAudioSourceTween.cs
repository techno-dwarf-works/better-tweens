using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MinDistanceAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.minDistance;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.minDistance = value;
        }
    }
}