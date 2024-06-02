using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class FillClockwiseImageTween : BoolTween<Image>
    {
        protected override bool GetCurrentValue()
        {
            return Target.fillClockwise;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.fillClockwise = value;
        }
    }
}