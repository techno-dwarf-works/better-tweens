﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class StartWidthLineRendererTween : FloatTween<LineRenderer>
    {
        protected override float GetCurrentValue()
        {
            return Target.startWidth;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.startWidth = value;
        }
    }
}