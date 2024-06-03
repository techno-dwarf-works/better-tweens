using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FarClipPlaneProjectorTween : FloatTween<Projector>
    {
        protected override float GetCurrentValue()
        {
            return Target.farClipPlane;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.farClipPlane = value;
        }
    }
}