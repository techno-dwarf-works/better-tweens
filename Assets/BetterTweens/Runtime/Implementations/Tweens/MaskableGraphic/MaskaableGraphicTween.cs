using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class MaskableGraphicTween : BoolTween<MaskableGraphic>
    {
        protected override bool GetCurrentValue()
        {
            return Target.maskable;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.maskable = value;
        }
    }
}