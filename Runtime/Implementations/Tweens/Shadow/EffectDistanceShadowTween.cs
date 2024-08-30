using System;
using UnityEngine;
using UnityEngine.UI;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class EffectDistanceShadowTween : Vector2Tween<Shadow>
    {
        protected override Vector2 GetCurrentValue()
        {
            return Target.effectDistance;
        }

        protected override void SetCurrentValue(Vector2 value)
        {
            Target.effectDistance = value;
        }
    }
}