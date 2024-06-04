using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class OrthographicSizeCameraTween : FloatTween<Camera>
    {
        protected override float GetCurrentValue()
        {
            return Target.orthographicSize;
        }

        protected override void SetCurrentValue(float value)
        {
            if (Mathf.Approximately(Target.orthographicSize, value))
            {
                return;
            }

            Target.orthographicSize = value;
        }
    }
}