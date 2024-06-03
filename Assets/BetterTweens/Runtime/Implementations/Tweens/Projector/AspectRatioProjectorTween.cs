using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AspectRatioProjectorTween : FloatTween<Projector>
    {
        protected override float GetCurrentValue()
        {
            return Target.aspectRatio;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.aspectRatio = value;
        }
    }
}