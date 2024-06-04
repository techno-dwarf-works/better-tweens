using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LineSpacingLayoutGroupTween : FloatTween<HorizontalOrVerticalLayoutGroup>
    {
        protected override float GetCurrentValue()
        {
            return Target.spacing;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.spacing, value))
            {
                return;
            }

            Target.spacing = value;
        }
    }
}