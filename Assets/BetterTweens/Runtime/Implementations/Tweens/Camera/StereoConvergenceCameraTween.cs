using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StereoConvergenceCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.stereoConvergence;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.stereoConvergence, value))
            {
                return;
            }

            Target.stereoConvergence = value;
        }
    }
}