using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class PreserveAspectImageTween : BoolTween<Image>
    {
        protected override bool GetCurrentValue()
        {
            return Target.preserveAspect;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.preserveAspect = value;
        }
    }
}