using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PanStereoAudioSourceTween : FloatTween<AudioSource>
    {
        protected override float GetCurrentValue()
        {
            return Target.panStereo;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.panStereo = value;
        }
    }
}