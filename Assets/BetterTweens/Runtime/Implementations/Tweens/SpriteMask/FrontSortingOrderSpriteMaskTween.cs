using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FrontSortingOrderSpriteMaskTween : IntTween<SpriteMask>
    {
        protected override int GetCurrentValue()
        {
            return Target.frontSortingOrder;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.frontSortingOrder = value;
        }
    }
}