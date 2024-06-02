using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class MaskingGraphicTween : BoolTween<MaskableGraphic>
    {
        protected override bool GetCurrentValue()
        {
            return Target.isMaskingGraphic;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.isMaskingGraphic = value;
        }
    }
}