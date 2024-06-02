using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class UseColorTemperatureLightTween : BoolTween<Light>
    {
        protected override bool GetCurrentValue()
        {
            return Target.useColorTemperature;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.useColorTemperature == value)
            {
                return;
            }

            Target.useColorTemperature = value;
        }
    }
}