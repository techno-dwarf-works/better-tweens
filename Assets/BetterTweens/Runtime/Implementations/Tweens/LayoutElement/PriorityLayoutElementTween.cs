using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PriorityLayoutElementTween : IntTween<LayoutElement>
    {
        protected override int GetCurrentValue()
        {
            return Target.layoutPriority;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.layoutPriority = value;
        }
    }
}