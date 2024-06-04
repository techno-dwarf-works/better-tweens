using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class DepthCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.depth;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.depth, value))
            {
                return;
            }

            Target.depth = value;
        }
    }
}