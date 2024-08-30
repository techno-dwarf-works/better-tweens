using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RoomAudioReverbFilterTween : FloatTween<AudioReverbFilter>
    {
        protected override float GetCurrentValue()
        {
            return Target.room;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.room = value;
        }
    }
}