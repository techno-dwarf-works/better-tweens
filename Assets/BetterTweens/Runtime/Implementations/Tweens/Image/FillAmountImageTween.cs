using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FillAmountImageTween : FloatTween<Image>
    {
        protected override float GetCurrentValue()
        {
            return Target.fillAmount;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.fillAmount = value;
        }
    }
}