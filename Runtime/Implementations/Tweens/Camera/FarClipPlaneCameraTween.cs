using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FarClipPlaneCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.farClipPlane;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.farClipPlane, value))
            {
                return;
            }

            Target.farClipPlane = value;
        }
    }
}