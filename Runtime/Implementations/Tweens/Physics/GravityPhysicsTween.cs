using System;
using UnityEngine;

namespace Better.Tweens.Runtime
{
    [Serializable]
    public class GravityPhysicsTween : Vector3Tween
    {
        protected override Vector3 GetCurrentValue()
        {
            return Physics.gravity;
        }

        protected override void SetCurrentValue(Vector3 value)
        {
            Physics.gravity = value;
        }
    }
}