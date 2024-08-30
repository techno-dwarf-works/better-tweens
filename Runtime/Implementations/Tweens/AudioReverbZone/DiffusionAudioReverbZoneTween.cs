using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DiffusionAudioReverbZoneTween : FloatTween<AudioReverbZone>
    {
        protected override float GetCurrentValue()
        {
            return Target.diffusion;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.diffusion = value;
        }
    }
}