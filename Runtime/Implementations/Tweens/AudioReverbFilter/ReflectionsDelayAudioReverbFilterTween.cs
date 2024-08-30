using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionsDelayAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.reflectionsDelay;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.reflectionsDelay = value;
        }
    }
}