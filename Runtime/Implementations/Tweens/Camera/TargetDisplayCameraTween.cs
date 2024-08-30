using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class TargetDisplayCameraTween : IntTween<Camera>
    {
        protected override int GetCurrentValue()
        {
            return Target.targetDisplay;
        }

        protected override void SetCurrentValue(int value)
        {
            if (Target.targetDisplay == value)
            {
                return;
            }

            Target.targetDisplay = value;
        }
    }
}