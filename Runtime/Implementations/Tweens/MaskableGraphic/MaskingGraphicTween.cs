using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MaskingGraphicTween : BoolTween<MaskableGraphic>
    {
        protected override bool GetCurrentValue()
        {
            return Target.isMaskingGraphic;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.isMaskingGraphic == value)
            {
                return;
            }
            
            Target.isMaskingGraphic = value;
        }
    }
}