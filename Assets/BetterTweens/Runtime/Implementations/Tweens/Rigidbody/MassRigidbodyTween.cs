using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class MassRigidbodyTween : FloatTween<Rigidbody>
    {
        protected override float GetCurrentValue()
        {
            return Target.mass;
        }

        protected override void SetCurrentValue(float value)
        {
            Target.mass = value;
        }
    }
}