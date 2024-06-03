using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SortingOrderRendererTween : IntTween<Renderer>
    {
        protected override int GetCurrentValue()
        {
            return Target.sortingOrder;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.sortingOrder = value;
        }
    }
}