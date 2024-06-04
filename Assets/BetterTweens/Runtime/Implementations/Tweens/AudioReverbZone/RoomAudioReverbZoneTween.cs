using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RoomAudioReverbZoneTween : IntTween<AudioReverbZone>
    {
        protected override int GetCurrentValue()
        {
            return Target.room;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.room = value;
        }
    }
}