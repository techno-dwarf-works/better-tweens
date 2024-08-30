using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class IgnoreLayoutElementTween : BoolTween<LayoutElement>
    {
        protected override bool GetCurrentValue()
        {
            return Target.ignoreLayout;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.ignoreLayout == value)
            {
                return;
            }
            
            Target.ignoreLayout = value;
        }
    }
}