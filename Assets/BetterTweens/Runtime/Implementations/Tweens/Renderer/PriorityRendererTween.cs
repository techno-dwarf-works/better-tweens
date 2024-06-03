using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class PriorityRendererTween : IntTween<Renderer>
    {
        protected override int GetCurrentValue()
        {
            return Target.rendererPriority;
        }

        protected override void SetCurrentValue(int value)
        {
            Target.rendererPriority = value;
        }
    }
}