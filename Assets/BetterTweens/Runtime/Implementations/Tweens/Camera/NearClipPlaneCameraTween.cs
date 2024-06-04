using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class NearClipPlaneCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.nearClipPlane;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.nearClipPlane, value))
            {
                return;
            }

            Target.nearClipPlane = value;
        }
    }
}