using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class InteractableCanvasGroupTween : BoolTween<CanvasGroup>
    {
        protected override bool GetCurrentValue()
        {
            return Target.interactable;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.interactable == value)
            {
                return;
            }

            Target.interactable = value;
        }
    }
}