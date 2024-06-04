using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RoomHFAudioReverbZoneTween : IntTween<AudioReverbZone>
    {
        protected override int GetCurrentValue()
        {
            return Target.roomHF;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.roomHF = value;
        }
    }
}