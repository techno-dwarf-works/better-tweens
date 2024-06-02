using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class RaycastTargetGraphicTween : BoolTween<Graphic>
    {
        protected override bool GetCurrentValue()
        {
            return Target.raycastTarget;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.raycastTarget == value)
            {
                return;
            }
            
            Target.raycastTarget = value;
        }
    }
}