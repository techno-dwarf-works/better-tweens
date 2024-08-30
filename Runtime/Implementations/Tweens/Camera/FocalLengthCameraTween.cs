using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FocalLengthCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.focalLength;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.focalLength, value))
            {
                return;
            }

            Target.focalLength = value;
        }
    }
}