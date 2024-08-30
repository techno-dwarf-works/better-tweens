using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class OrthographicCameraTween : BoolTween<Camera>
    {
        protected override bool GetCurrentValue()
        {
            return Target.orthographic;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.orthographic == value)
            {
                return;
            }

            Target.orthographic = value;
        }
    }
}