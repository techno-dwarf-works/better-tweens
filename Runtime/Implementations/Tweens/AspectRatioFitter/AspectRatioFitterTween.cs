using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AspectRatioFitterTween : FloatTween<AspectRatioFitter>
    {
        protected override float GetCurrentValue()
        {
            return Target.aspectRatio;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.aspectRatio, value))
            {
                return;
            }

            Target.aspectRatio = value;
        }
    }
}