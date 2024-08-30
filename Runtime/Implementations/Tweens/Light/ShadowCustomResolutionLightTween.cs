using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShadowCustomResolutionLightTween : IntTween<Light>
    {
        protected override int GetCurrentValue()
        {
            return Target.shadowCustomResolution;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.shadowCustomResolution = value;
        }
    }
}