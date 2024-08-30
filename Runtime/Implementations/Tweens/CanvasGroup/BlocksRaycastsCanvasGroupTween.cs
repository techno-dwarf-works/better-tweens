using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BlocksRaycastsCanvasGroupTween : BoolTween<CanvasGroup>
    {
        protected override bool GetCurrentValue()
        {
            return Target.blocksRaycasts;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.blocksRaycasts == value)
            {
                return;
            }

            Target.blocksRaycasts = value;
        }
    }
}