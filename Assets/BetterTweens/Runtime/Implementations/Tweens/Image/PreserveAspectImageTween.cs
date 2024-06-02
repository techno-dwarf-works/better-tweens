using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PreserveAspectImageTween : BoolTween<Image>
    {
        protected override bool GetCurrentValue()
        {
            return Target.preserveAspect;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.preserveAspect == value)
            {
                return;
            }
            
            Target.preserveAspect = value;
        }
    }
}