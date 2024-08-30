using System;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FillClockwiseImageTween : BoolTween<Image>
    {
        protected override bool GetCurrentValue()
        {
            return Target.fillClockwise;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.fillClockwise == value)
            {
                return;
            }

            Target.fillClockwise = value;
        }
    }
}