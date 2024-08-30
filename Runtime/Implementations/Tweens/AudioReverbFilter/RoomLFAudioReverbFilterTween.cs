using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RoomLFAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.roomLF;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.roomLF = value;
        }
    }
}