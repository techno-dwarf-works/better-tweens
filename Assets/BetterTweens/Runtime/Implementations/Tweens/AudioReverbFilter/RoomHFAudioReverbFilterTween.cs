using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RoomHFAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.roomHF;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.roomHF = value;
        }
    }
}