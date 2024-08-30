using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FadeCanvasGroupTween : FloatTween<CanvasGroup>
    {
        protected override float GetCurrentValue()
        {
            return Target.alpha;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.alpha = value;
        }
    }
}