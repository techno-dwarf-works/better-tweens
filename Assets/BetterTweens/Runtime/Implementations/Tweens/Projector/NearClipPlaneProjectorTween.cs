using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NearClipPlaneProjectorTween : FloatTween<Projector>
    {
        protected override float GetCurrentValue()
        {
            return Target.nearClipPlane;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.nearClipPlane = value;
        }
    }
}