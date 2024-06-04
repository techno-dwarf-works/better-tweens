using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class SensorSizeCameraTween : Vector2Tween<Camera>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.sensorSize;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.sensorSize = value;
        }
    }
}