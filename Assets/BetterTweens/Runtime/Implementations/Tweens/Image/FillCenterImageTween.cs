﻿using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    public class FillCenterImageTween : BoolTween<Image>
    {
        protected override bool GetCurrentValue()
        {
            return Target.fillCenter;
        }

        protected override void SetCurrentValue(bool value)
        {
            Target.fillCenter = value;
        }
    }
}