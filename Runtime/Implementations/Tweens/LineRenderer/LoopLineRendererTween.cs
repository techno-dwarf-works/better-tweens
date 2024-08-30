﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class LoopLineRendererTween : BoolTween<LineRenderer>
    {
        protected override bool GetCurrentValue()
        {
            return Target.loop;
        }

        protected override void SetCurrentValue(bool value)
        {
            if (Target.loop == value)
            {
                return;
            }

            Target.loop = value;
        }
    }
}