using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EmittingTrailRendererTween : BoolTween<TrailRenderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.emitting;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.emitting == value)
            {
                return;
            }

            Target.emitting = value;
        }
    }
}