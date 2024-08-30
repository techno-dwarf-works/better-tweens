using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReflectionsLevelAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.reflectionsLevel;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.reflectionsLevel = value;
        }
    }
}