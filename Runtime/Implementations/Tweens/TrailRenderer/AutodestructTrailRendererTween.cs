using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AutodestructTrailRendererTween : BoolTween<TrailRenderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.autodestruct;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.autodestruct == value)
            {
                return;
            }

            Target.autodestruct = value;
        }
    }
}