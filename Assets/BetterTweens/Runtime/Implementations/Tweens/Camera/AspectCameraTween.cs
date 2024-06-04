using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class AspectCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.aspect;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.aspect, value))
            {
                return;
            }

            Target.aspect = value;
        }
    }
}