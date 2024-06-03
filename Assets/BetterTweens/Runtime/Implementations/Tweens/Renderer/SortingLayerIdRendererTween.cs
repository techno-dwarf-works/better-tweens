using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SortingLayerIdRendererTween : IntTween<Renderer>
    {
        protected override int GetCurrentValue()
        {
            return Target.sortingLayerID;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.sortingLayerID = value;
        }
    }
}