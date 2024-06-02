using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class FlexibleSizeLayoutElementTween : Vector2Tween<LayoutElement>
    {
        protected override Vector2 GetCurrentValue()
        {
            var flexible = new Vector2(Target.flexibleWidth, Target.flexibleHeight);
            return flexible;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.flexibleWidth = value.x;
            Target.flexibleHeight = value.y;
        }
    }
}