using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StereoSeparationCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.stereoSeparation;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.stereoSeparation, value))
            {
                return;
            }

            Target.stereoSeparation = value;
        }
    }
}