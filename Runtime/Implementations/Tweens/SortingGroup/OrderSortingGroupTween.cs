using System;
using UnityEngine.Rendering;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class OrderSortingGroupTween : IntTween<SortingGroup>
    {
        protected override int GetCurrentValue()
        {
            return Target.sortingOrder;
        }

        protected override void SetCurrentValue(int value)
        {
            if (Target.sortingOrder == value)
            {
                return;
            }

            Target.sortingOrder = value;
        }
    }
}