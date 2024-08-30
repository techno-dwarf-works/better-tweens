﻿using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class BouncinessPhysicMaterialTween : FloatTween<PhysicMaterial>
    {
        protected override float GetCurrentValue()
        {
            return Target.bounciness;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.bounciness = value;
        }
    }
}