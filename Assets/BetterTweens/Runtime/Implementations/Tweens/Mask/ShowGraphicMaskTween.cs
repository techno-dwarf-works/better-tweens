using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class ShowGraphicMaskTween : BoolTween<Mask>
    {
        protected override bool GetCurrentValue()
        {
            return Target.showMaskGraphic;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.showMaskGraphic == value)
            {
                return;
            }

            Target.showMaskGraphic = value;
        }
    }
}