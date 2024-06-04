using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class CustomRangeSpriteMaskTween : BoolTween<SpriteMask>
    {
        protected override bool GetCurrentValue()
        {
            return Target.isCustomRangeActive;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.isCustomRangeActive == value)
            {
                return;
            }

            Target.isCustomRangeActive = value;
        }
    }
}