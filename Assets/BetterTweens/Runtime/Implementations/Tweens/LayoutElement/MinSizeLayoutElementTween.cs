using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class MinSizeLayoutElementTween : Vector2Tween<LayoutElement>
    {
        protected override Vector2 GetCurrentValue()
        {
            var flexible = new Vector2(Target.minWidth, Target.minHeight);
            return flexible;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.minWidth = value.x;
            Target.minHeight = value.y;
        }
    }
}