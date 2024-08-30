using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MaskableGraphicTween : BoolTween<MaskableGraphic>
    {
        protected override bool GetCurrentValue()
        {
            return Target.maskable;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.maskable == value)
            {
                return;
            }
            
            Target.maskable = value;
        }
    }
}