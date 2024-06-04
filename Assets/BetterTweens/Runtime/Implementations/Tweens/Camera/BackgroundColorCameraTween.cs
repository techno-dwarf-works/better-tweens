using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BackgroundColorCameraTween : ColorTween<Camera>
    {
        protected override Color GetCurrentValue()
        {
            return Target.backgroundColor;
        }

        protected override void SetCurrentValue(Color value)
        {
            if (Target.backgroundColor == value)
            {
                return;
            }

            Target.backgroundColor = value;
        }
    }
}