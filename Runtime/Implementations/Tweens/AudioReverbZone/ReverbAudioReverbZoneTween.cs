using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ReverbAudioReverbZoneTween : IntTween<AudioReverbZone>
    {
        protected override int GetCurrentValue()
        {
            return Target.reverb;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.reverb = value;
        }
    }
}