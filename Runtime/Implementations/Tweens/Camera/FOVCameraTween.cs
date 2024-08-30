using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class FOVCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.fieldOfView;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.fieldOfView, value))
            {
                return;
            }

            Target.fieldOfView = value;
        }
    }
}