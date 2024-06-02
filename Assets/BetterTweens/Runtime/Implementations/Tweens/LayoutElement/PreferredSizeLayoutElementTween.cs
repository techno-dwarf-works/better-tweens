using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class PreferredSizeLayoutElementTween : Vector2Tween<LayoutElement>
    {
        protected override Vector2 GetCurrentValue()
        {
            var flexible = new Vector2(Target.preferredWidth, Target.preferredHeight);
            return flexible;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.preferredWidth = value.x;
            Target.preferredHeight = value.y;
        }
    }
}