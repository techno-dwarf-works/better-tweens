using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class RaycastTargetGraphicTween : BoolTween<Graphic>
    {
        protected override bool GetCurrentValue()
        {
            return Target.raycastTarget;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.raycastTarget = value;
        }
    }
}