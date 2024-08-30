﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EnableBehaviourTween : BoolTween<Behaviour>
    {
        protected override bool GetCurrentValue()
        {
            return Target.enabled;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.enabled == value)
            {
                return;
            }
            
            Target.enabled = value;
        }
    }
}