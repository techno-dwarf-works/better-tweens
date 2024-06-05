using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class VerticalNormalizedPositionScrollRectTween : FloatTween<ScrollRect>
    {
        protected override float GetCurrentValue()
        {
            return Target.verticalNormalizedPosition;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.verticalNormalizedPosition = value;
        }
    }
}