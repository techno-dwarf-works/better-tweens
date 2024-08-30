using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionsAudioReverbZoneTween : IntTween<AudioReverbZone>
    {
        protected override int GetCurrentValue()
        {
            return Target.reflections;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.reflections = value;
        }
    }
}