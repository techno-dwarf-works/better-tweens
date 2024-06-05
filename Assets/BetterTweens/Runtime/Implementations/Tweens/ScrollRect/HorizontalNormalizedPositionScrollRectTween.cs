using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class HorizontalNormalizedPositionScrollRectTween : FloatTween<ScrollRect>
    {
        protected override float GetCurrentValue()
        {
            return Target.horizontalNormalizedPosition;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.horizontalNormalizedPosition = value;
        }
    }
}