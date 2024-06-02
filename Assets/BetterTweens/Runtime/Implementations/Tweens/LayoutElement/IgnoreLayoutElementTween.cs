using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class IgnoreLayoutElementTween : BoolTween<LayoutElement>
    {
        protected override bool GetCurrentValue()
        {
            return Target.ignoreLayout;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.ignoreLayout = value;
        }
    }
}