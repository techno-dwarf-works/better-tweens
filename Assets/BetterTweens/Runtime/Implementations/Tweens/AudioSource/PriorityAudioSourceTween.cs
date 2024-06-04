using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PriorityAudioSourceTween : IntTween<AudioSource>
    {
        protected override int GetCurrentValue()
        {
            return Target.priority;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.priority = value;
        }
    }
}