using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BypassReverbZonesAudioSourceTween : BoolTween<AudioSource>
    {
        protected override bool GetCurrentValue()
        {
            return Target.bypassReverbZones;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.bypassReverbZones == value)
            {
                return;
            }

            Target.bypassReverbZones = value;
        }
    }
}