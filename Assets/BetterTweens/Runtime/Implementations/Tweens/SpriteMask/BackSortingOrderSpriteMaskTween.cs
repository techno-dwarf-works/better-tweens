using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BackSortingOrderSpriteMaskTween : IntTween<SpriteMask>
    {
        protected override int GetCurrentValue()
        {
            return Target.backSortingOrder;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.backSortingOrder = value;
        }
    }
}