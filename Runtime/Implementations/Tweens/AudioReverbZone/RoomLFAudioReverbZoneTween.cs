using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RoomLFAudioReverbZoneTween : IntTween<AudioReverbZone>
    {
        protected override int GetCurrentValue()
        {
            return Target.roomLF;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.roomLF = value;
        }
    }
}