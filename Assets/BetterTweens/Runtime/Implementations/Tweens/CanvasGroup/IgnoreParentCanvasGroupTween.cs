using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class IgnoreParentCanvasGroupTween : BoolTween<CanvasGroup>
    {
        protected override bool GetCurrentValue()
        {
            return Target.ignoreParentGroups;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.ignoreParentGroups == value)
            {
                return;
            }
            
            Target.ignoreParentGroups = value;
        }
    }
}