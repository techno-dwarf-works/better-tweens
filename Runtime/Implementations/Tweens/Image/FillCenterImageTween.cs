using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FillCenterImageTween : BoolTween<Image>
    {
        protected override bool GetCurrentValue()
        {
            return Target.fillCenter;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.fillCenter == value)
            {
                return;
            }

            Target.fillCenter = value;
        }
    }
}