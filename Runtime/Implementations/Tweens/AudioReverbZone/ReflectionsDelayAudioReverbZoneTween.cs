using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionsDelayAudioReverbZoneTween : FloatTween<AudioReverbZone>
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