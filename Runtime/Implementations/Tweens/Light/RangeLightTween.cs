using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RangeLightTween : FloatTween<Light>
    {
        protected override float GetCurrentValue()
        {
            return Target.range;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.range = value;
        }
    }
}